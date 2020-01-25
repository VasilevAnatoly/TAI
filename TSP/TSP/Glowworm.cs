using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNeighbor
{
    public class Firefly
    {
        public int Name { get; set; }
        public List<Edge> Trail { get; set; }
        public int TrailLength { get; set; }

        public Firefly(int name)
        {
            Name = name;
            Trail = new List<Edge>();
            TrailLength = int.MaxValue;
        }
    }

    class Glowworm
    {
        private static Random rnd = new Random();

        public List<Edge> Algorithm(int maxEpochs, int numFireflies, List<Edge> edges, List<Vertex> vertexes, double b0, double g, double a)
        {
            List<Edge> localEdges = Utils.CopyEdges(edges);

            List<Firefly> fireflies = new List<Firefly>();

            int bestLength = Int32.MaxValue;

            for (int i = 0; i < numFireflies; i++)
            {
                fireflies.Add(new Firefly(i));
                List<Vertex> currVertexes = new List<Vertex>(vertexes);

                var randomStartVert = rnd.Next(0, currVertexes.Count);

                var randomVertexes = Utils.GetRandomVertexes(randomStartVert + 1, currVertexes);

                var path = Utils.GetPath(randomVertexes, localEdges);

                fireflies[i].Trail = Utils.GetPath(randomVertexes, localEdges);
                fireflies[i].TrailLength = Utils.GetPathLength(fireflies[i].Trail);
            }

            List<Edge> bestTrail = fireflies.FirstOrDefault(f => f.TrailLength == fireflies.Min(ant => ant.TrailLength)).Trail;
            bestLength = Utils.GetPathLength(bestTrail);

            int time = 0;

            while (time < maxEpochs)
            {

                for (int i = 0; i < fireflies.Count; ++i) // цикл по каждому светлячку
                {
                    for (int j = 0; j < fireflies.Count; ++j)
                    {
                        // если у текущего светлячка интенсивность свечения меньше - перемещаем его к соседнему
                        if (fireflies[i].TrailLength > fireflies[j].TrailLength)
                        {
                            // curr firefly i is less intense (i is worse) so move i toward j
                            double r = Utils.DistanceBetweenTrails(fireflies[i].Trail, fireflies[j].Trail);
                            double beta = b0 * Math.Exp(-g * r * r); // original 
                                                                     //double beta = (B0 - betaMin) * Math.Exp(-g * r * r) + betaMin; // better
                                                                     //double a = a0 * Math.Pow(0.98, epoch); // better
                            //for (int k = 0; k < dim; ++k)
                            //{
                            //    swarm[i].position[k] += beta * (swarm[j].position[k] - swarm[i].position[k]);
                            //    swarm[i].position[k] += a * (rnd.NextDouble() - 0.5);
                            //    if (swarm[i].position[k] < minVal[k]) swarm[i].position[k] = (maxVal[k] - minVal[k]) * rnd.NextDouble() + minVal[k];
                            //    if (swarm[i].position[k] > maxVal[k]) swarm[i].position[k] = (maxVal[k] - minVal[k]) * rnd.NextDouble() + minVal[k];
                            //}
                        }
                    } // j
                } // i each firefly

                List<Edge> localTrail = fireflies.FirstOrDefault(f => f.TrailLength == fireflies.Min(ant => ant.TrailLength)).Trail;
                int localLength = Utils.GetPathLength(bestTrail);

                if (localLength < bestLength)
                {
                    bestLength = localLength;
                    bestTrail = localTrail;
                }

                time += 1;
            }
            return bestTrail;
        }
    }
}
