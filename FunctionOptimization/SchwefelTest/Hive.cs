using System.Collections.Generic;
using System.Linq;

namespace GeneticGUI
{
    class Hive
    {
        public int beesScoutCount;
        public int beesToSelectedCount;
        public int beesToBestCount;
        public int selectedAreasCount;
        public int bestAreasCount;

        public int beesAllCount;

        public List<Bee> bestBees;
        public List<Bee> selectedBees;

        public List<double> varRangesList;

        public List<double> bestPosition;
        public double bestFitness;

        public List<Bee> swarm;

        public Hive(int beesScoutCount, int beesToSelectedCount, int beesToBestCount,
            int selectedAreasCount, int bestAreasCount, List<double> minVal, List<double> maxVal, List<FunctionParser.FOperator> Data)
        {
            Bee.Data = Data;

            this.beesScoutCount = beesScoutCount;
            this.beesToSelectedCount = beesToSelectedCount;
            this.beesToBestCount = beesToBestCount;
            this.selectedAreasCount = selectedAreasCount;
            this.bestAreasCount = bestAreasCount;

            varRangesList = new List<double>(minVal.Count);

            for (int i = 0; i < minVal.Count; i++)
            {
                varRangesList.Add(maxVal[i] - minVal[i]);
            }

            beesAllCount = beesScoutCount + beesToSelectedCount * selectedAreasCount + beesToBestCount * bestAreasCount;

            swarm = new List<Bee>(beesAllCount);

            for (int i = 0; i < beesAllCount; i++)
            {
                swarm.Add(new Bee(varRangesList.Count, minVal, maxVal));
            }

            swarm = swarm.OrderBy(bee => bee.fitness).ToList();

            bestPosition = swarm[0].GetPosition();
            bestFitness = swarm[0].fitness;

            bestBees = new List<Bee>();
            selectedBees = new List<Bee>();
        }

        public void NextStep()
        {
            bestBees = new List<Bee>();

            bestBees.Add(swarm[0]);

            int i = 0;
            foreach (var currBee in swarm)
            {
                if (currBee.CheckAnotherBees(bestBees, varRangesList))
                {
                    bestBees.Add(currBee);

                    if (bestBees.Count == beesToBestCount)
                        break;
                }
                i++;
            }

            selectedBees = new List<Bee>();

            for (; i < swarm.Count; i++)
            {
                var currBee = swarm[i];

                if (currBee.CheckAnotherBees(bestBees, varRangesList) && currBee.CheckAnotherBees(selectedBees, varRangesList))
                {
                    selectedBees.Add(currBee);

                    if (selectedBees.Count == beesToSelectedCount)
                        break;
                }
            }

            var beeIndex = 1;

            foreach (var bestBee in bestBees)
            {
                beeIndex = SendBees(bestBee.GetPosition(), beeIndex, beesToBestCount);
            }

            foreach (var bestBee in selectedBees)
            {
                beeIndex = SendBees(bestBee.GetPosition(), beeIndex, beesToSelectedCount);
            }

            for (int idx = beeIndex; idx < swarm.Count; idx++)
            {
                swarm[idx].GotoRandom();
            }

            swarm = swarm.OrderBy(bee => bee.fitness).ToList();

            bestPosition = swarm[0].GetPosition();
            bestFitness = swarm[0].fitness;
        }

        public void Run(int maxIterations, int localCounter)
        {
            int i = 0;

            double bestFit = double.MaxValue;

            int localCount = 0;

            while (i < maxIterations)
            {
                NextStep();

                if (bestFitness != bestFit)
                {
                    bestFit = bestFitness;
                    localCount = 0;
                }
                else
                {
                    ++localCount;

                    if (localCount == localCounter)
                    {
                        localCount = 0;

                        for (int j = 0; j < varRangesList.Count; j++)
                        {
                            varRangesList[j] = varRangesList[j] * GetDecreseVarRangeCoeff();
                        }

                    }
                }
                i++;
            }
        }

        public int SendBees(List<double> position, int index, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (index == swarm.Count)
                    break;

                if (!bestBees.Contains(swarm[index]) && !selectedBees.Contains(swarm[index]))
                {
                    swarm[index].Goto(position, varRangesList);
                }
                index++;
            }
            return index;
        }

        public double GetDecreseVarRangeCoeff()
        {
            return 0.95;
        }
    }
}
