using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbor
{
    class Hive
    {
        static Random random = new Random(); // multipurpose

        public int totalNumberBees; // mostly for readability in the object constructor call
        public int numberInactive;
        public int numberActive;
        public int numberScout;

        public int maxNumberCycles; // one cycle represents an action by all bees in the hive
        //public int maxCyclesWithNoImprovement; // deprecated

        public int maxNumberVisits; // max number of times bee will visit a given food source without finding a better neighbor
        public double probPersuasion = 0.95; // probability inactive bee is persuaded by better waggle solution
        // public double probMistake = 0.01; // probability an active bee will reject a better neighbor food source OR accept worse neighbor food source
        public double probMistake;

        public Bee[] bees;
        public List<Edge> bestTrail; // problem-specific
        public double bestTotalDistance;
        public int[] indexesOfInactiveBees; // contains indexes into the bees array

        private List<Vertex> vertexes;
        private List<Edge> edges;

        public Hive(int totalNumberBees, int numberInactive, int numberActive, int numberScout, int maxNumberVisits,
          int maxNumberCycles, double probMistake, List<Vertex> vertexes, List<Edge> edges)
        {
            this.totalNumberBees = totalNumberBees;
            this.numberInactive = numberInactive;
            this.numberActive = numberActive;
            this.numberScout = numberScout;
            this.maxNumberVisits = maxNumberVisits;
            this.maxNumberCycles = maxNumberCycles;

            this.vertexes = vertexes;
            this.edges = edges;

            // this.probPersuasion & this.probMistake are hard-coded in class definition
            this.probMistake = probMistake;

            this.bees = new Bee[totalNumberBees];

            // Provides the baseline best random memory matrix
            this.bestTrail = GenerateRandomPath(vertexes, edges); // alternative initializations are possible
            this.bestTotalDistance = Utils.GetPathLength(this.bestTrail);

            this.indexesOfInactiveBees = new int[numberInactive]; // indexes of bees which are currently inactive

            for (int i = 0; i < totalNumberBees; ++i) // initialize each bee, and best solution
            {
                int currStatus; // depends on i. need status before we can initialize Bee
                if (i < numberInactive)
                {
                    currStatus = 0; // inactive
                    indexesOfInactiveBees[i] = i; // curr bee is inactive
                }
                else if (i < numberInactive + numberScout)
                {
                    currStatus = 2; // scout
                }
                else
                {
                    currStatus = 1; // active
                }

                List<Edge> randomPath = GenerateRandomPath(vertexes, edges);
                double mq = Utils.GetPathLength(randomPath);
                int numberOfVisits = 0;

                bees[i] = new Bee(currStatus, randomPath, mq, numberOfVisits); // instantiate current bee

                // does this bee have best solution?
                if (bees[i].totalDistance < bestTotalDistance) // curr bee is better (< because smaller is better)
                {
                    bees[i].trail = Utils.CopyEdges(this.bestTrail);
                    this.bestTotalDistance = bees[i].totalDistance;
                }
            } // each bee

        } // TravelingSalesmanHive ctor


        public List<Edge> GenerateRandomPath(List<Vertex> vertexes, List<Edge> edges)
        {
            List<Vertex> temp = new List<Vertex>(vertexes);
            for (int i = 0; i < temp.Count; ++i) // Fisher-Yates shuffle
            {
                int r = random.Next(i, temp.Count);
                Vertex tmp = temp[r]; temp[r] = temp[i]; temp[i] = tmp;
            }

            return Utils.GetPath(temp, edges);
        }


        public List<Edge> GenerateNeighborMemoryMatrix(List<Edge> beeTrail)
        {
            List<Vertex> beeVertexes = beeTrail.Select(e => e.startVert).ToList();

            List<Vertex> temp = new List<Vertex>(beeVertexes);
            int ranIndex = random.Next(0, temp.Count); // [0, Length-1] inclusive
            int adjIndex;
            if (ranIndex == temp.Count - 1)
                adjIndex = 0;
            else
                adjIndex = ranIndex + 1;

            Vertex tmp = temp[ranIndex];
            temp[ranIndex] = temp[adjIndex];
            temp[adjIndex] = tmp;

            return Utils.GetPath(temp, edges);
        }

        public List<Edge> Algorithm() // find best Traveling Salesman Problem solution
        {
            int cycle = 0;

            var sw = System.Diagnostics.Stopwatch.StartNew();

            while (cycle < this.maxNumberCycles)
            {
                for (int i = 0; i < this.totalNumberBees; ++i) // each bee
                {
                    switch (this.bees[i].status)
                    {
                        case 1:
                            ProcessActiveBee(i);
                            break;
                        case 2:
                            ProcessScoutBee(i);
                            break;
                        case 0:
                            //ProcessInactiveBee(i);
                            break;
                    }
                } // for each bee

                ++cycle;
            } // main while processing loop

            sw.Stop();

            return bestTrail;
        } // Solve()

        private void ProcessInactiveBee(int i)
        {
            return; // not used in this implementation
        }

        private void ProcessActiveBee(int i)
        {
            List<Edge> neighbor = GenerateNeighborMemoryMatrix(bees[i].trail); // find a neighbor solution
            double neighborQuality = Utils.GetPathLength(neighbor); // get its quality
            double prob = random.NextDouble(); // used to determine if bee makes a mistake; compare against probMistake which has some small value (~0.01)
            bool memoryWasUpdated = false; // used to determine if bee should perform a waggle dance when done
            bool numberOfVisitsOverLimit = false; // used to determine if bee will convert to inactive status

            if (neighborQuality < bees[i].totalDistance) // active bee found better neighbor (< because smaller values are better)
            {
                if (prob < probMistake) // bee makes mistake: rejects a better neighbor food source
                {
                    ++bees[i].numberOfVisits; // no change to memory but update number of visits
                    if (bees[i].numberOfVisits > maxNumberVisits) numberOfVisitsOverLimit = true;
                }
                else // bee does not make a mistake: accepts a better neighbor
                {
                    bees[i].trail = Utils.CopyEdges(neighbor); // copy neighbor location into bee's memory
                    bees[i].totalDistance = neighborQuality; // update the quality
                    bees[i].numberOfVisits = 0; // reset counter
                    memoryWasUpdated = true; // so that this bee will do a waggle dance 
                }
            }
            else // active bee did not find a better neighbor
            {
                if (prob < probMistake) // bee makes mistake: accepts a worse neighbor food source
                {
                    bees[i].trail = Utils.CopyEdges(neighbor); // copy neighbor location into bee's memory
                    bees[i].totalDistance = neighborQuality; // update the quality
                    bees[i].numberOfVisits = 0; // reset
                    memoryWasUpdated = true; // so that this bee will do a waggle dance 
                }
                else // no mistake: bee rejects worse food source
                {
                    ++bees[i].numberOfVisits;
                    if (bees[i].numberOfVisits > maxNumberVisits) numberOfVisitsOverLimit = true;
                }
            }

            // at this point we need to determine a.) if the number of visits has been exceeded in which case bee becomes inactive
            // or b.) memory was updated in which case check to see if new memory is a global best, and then bee does waggle dance
            // or c.) neither in which case nothing happens (bee just returns to hive).

            if (numberOfVisitsOverLimit == true)
            {
                bees[i].status = 0; // current active bee transitions to inactive
                bees[i].numberOfVisits = 0; // reset visits (and no change to this bees memory)
                int x = random.Next(numberInactive); // pick a random inactive bee. x is an index into a list, not a bee ID
                bees[indexesOfInactiveBees[x]].status = 1; // make it active
                indexesOfInactiveBees[x] = i; // record now-inactive bee 'i' in the inactive list
            }
            else if (memoryWasUpdated == true) // current bee returns and performs waggle dance
            {
                // first, determine if the new memory is a global best. note that if bee has accepted a worse food source this can't be true
                if (bees[i].totalDistance < this.bestTotalDistance) // the modified bee's memory is a new global best (< because smaller is better)
                {
                    this.bestTrail = Utils.CopyEdges(bees[i].trail); // update global best memory
                    this.bestTotalDistance = bees[i].totalDistance; // update global best quality
                }
                DoWaggleDance(i);
            }
            else // number visits is not over limit and memory was not updated so do nothing (return to hive but do not waggle)
            {
                return;
            }
        } // ProcessActiveBee()

        private void ProcessScoutBee(int i)
        {
            List<Edge> randomFoodSource = GenerateRandomPath(this.vertexes, this.edges); // scout bee finds a random food source. . . 
            double randomFoodSourceQuality = Utils.GetPathLength(randomFoodSource); // and examines its quality
            if (randomFoodSourceQuality < bees[i].totalDistance) // scout bee has found a better solution than its current one (< because smaller measure is better)
            {
                bees[i].trail = Utils.CopyEdges(randomFoodSource); // unlike active bees, scout bees do not make mistakes
                bees[i].totalDistance = randomFoodSourceQuality;
                // no change to scout bee's numberOfVisits or status

                // did this scout bee find a better overall/global solution?
                if (bees[i].totalDistance < this.bestTotalDistance) // yes, better overall solution (< because smaller is better)
                {
                    this.bestTrail = Utils.CopyEdges(bees[i].trail); // copy scout bee's memory to global best
                    this.bestTotalDistance = bees[i].totalDistance;
                } // better overall solution

                DoWaggleDance(i); // scout returns to hive and does waggle dance

            } // if scout bee found better solution
        } // ProcessScoutBee()

        private void DoWaggleDance(int i)
        {
            for (int ii = 0; ii < numberInactive; ++ii) // each inactive/watcher bee
            {
                int b = indexesOfInactiveBees[ii]; // index of an inactive bee
                if (bees[b].status != 0) throw new Exception("Catastrophic logic error when scout bee waggles dances");
                if (bees[b].numberOfVisits != 0) throw new Exception("Found an inactive bee with numberOfVisits != 0 in Scout bee waggle dance routine");
                if (bees[i].totalDistance < bees[b].totalDistance) // scout bee has a better solution than current inactive/watcher bee (< because smaller is better)
                {
                    double p = random.NextDouble(); // will current inactive bee be persuaded by scout's waggle dance?
                    if (this.probPersuasion > p) // this inactive bee is persuaded by the scout (usually because probPersuasion is large, ~0.90)
                    {
                        bees[b].trail = Utils.CopyEdges(bees[i].trail);
                        bees[b].totalDistance = bees[i].totalDistance;
                    } // inactive bee has been persuaded
                } // scout bee has better solution than watcher/inactive bee
            } // each inactive bee
        } // DoWaggleDance()

    } // class ShortestPathHive
}
