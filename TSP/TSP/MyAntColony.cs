using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbor
{
    class MyAntColony
    {
        private static Random rnd = new Random();
        // influence of pheromone on direction
        public static int alpha;
        // influence of adjacent node distance
        public static int beta;
        // pheromone decrease factor
        public static double rho;
        // pheromone increase factor
        public static double Q;

        public static List<Edge> Algorithm(int numAnts, List<Edge> edges, List<Vertex> vertexes, int maxTime)
        {
            List<Edge> localEdges = Utils.CopyEdges(edges);

            double[][] pheromones = new double[vertexes.Count][];
            List<Ant> ants = new List<Ant>(numAnts);

            int bestLength = Int32.MaxValue;

            for (int i = 0; i < numAnts; i++)
            {
                ants.Add(new Ant(i));
                List<Vertex> currVertexes = new List<Vertex>(vertexes);

                var randomStartVert = rnd.Next(0, currVertexes.Count);

                var randomVertexes = Utils.GetRandomVertexes(randomStartVert + 1, currVertexes);

                var path = Utils.GetPath(randomVertexes, localEdges);

                ants[i].Trail = Utils.GetPath(randomVertexes, localEdges);
                ants[i].TrailLength = Utils.GetPathLength(ants[i].Trail);
            }

            List<Edge> bestTrail = ants.FirstOrDefault(a => a.TrailLength == ants.Min(ant => ant.TrailLength)).Trail;
            bestLength = Utils.GetPathLength(bestTrail);

            pheromones = InitPheromones(vertexes.Count);

            int time = 0;

            while (time < maxTime)
            {
                UpdateAnts(ants, pheromones, localEdges);
                UpdatePheromones(pheromones, ants);

                List<Edge> localTrail = ants.FirstOrDefault(a => a.TrailLength == ants.Min(ant => ant.TrailLength)).Trail;
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

        private static void UpdateAnts(List<Ant> ants, double[][] pheromones, List<Edge> edges)
        {
            for (int k = 0; k < ants.Count; k++)
            {
                int startCity = rnd.Next(0, pheromones.Length);
                ants[k].Trail = BuildTrail(startCity + 1, pheromones, edges);
                if (ants[k].Trail != null)
                {
                    ants[k].TrailLength = ants[k].Trail.Sum(e => e.Cost);
                }
                else
                {
                    ants[k].TrailLength = Int32.MaxValue;
                }
            }
        }

        private static List<Edge> BuildTrail(int startCity, double[][] pheromones, List<Edge> _edges)
        {
            //сюда заносить копии
            List<Edge> trail = new List<Edge>();
            int startTemp = startCity;
            var edges = new List<Edge>();
            edges = Utils.CopyEdges(_edges);
            for (; ; )
            {
                //получаем все возможные непосещенные ребра, по которым может муравей пройти из города
                var probEdges = edges.Where(e => e.startVert.Name == startCity && !e.endVert.IsVisited).ToList();
                //массив вероятностей перехода муравья в тот или иной город

                if (probEdges.Count > 0)
                {
                    double[] probs = new double[probEdges.Count];
                    double[] taueta = new double[probEdges.Count];
                    double sum = 0.0;

                    for (int i = 0; i <= taueta.Length - 1; i++)
                    {
                        taueta[i] =
                            Math.Pow(pheromones[probEdges[i].startVert.Name - 1][probEdges[i].endVert.Name - 1], alpha) *
                            Math.Pow((1.0 / probEdges[i].Cost), beta);
                        if (taueta[i] < 0.0001)
                        {
                            taueta[i] = 0.0001;
                        }
                        else if (taueta[i] > (double.MaxValue / (probEdges.Count * 100)))
                        {
                            taueta[i] = double.MaxValue / (probEdges.Count * 100);
                        }
                        sum += taueta[i];
                    }
                    for (int i = 0; i <= probs.Length - 1; i++)
                    {
                        probs[i] = taueta[i] / sum;
                    }
                    double[] cumul = new double[probs.Length + 1];
                    for (int i = 0; i <= probs.Length - 1; i++)
                    {
                        cumul[i + 1] = cumul[i] + probs[i];
                    }

                    double p = rnd.NextDouble();

                    for (int i = 0; i <= cumul.Length - 2; i++)
                    {
                        if (p >= cumul[i] && p < cumul[i + 1])
                        {
                            trail.Add(probEdges[i]);
                            startCity = probEdges[i].endVert.Name;
                            probEdges[i].startVert.IsVisited = true;
                        }
                    }
                }
                else
                {
                    var edge = edges.FirstOrDefault(e => e.startVert.Name == startCity && e.endVert.Name == startTemp);
                    if (edge != null)
                    {
                        trail.Add(edge);
                        break;
                    }
                    else
                    {
                        trail = null;
                        break;
                    }
                }
            }
            return trail;
        }


        private static double[][] InitPheromones(int numCities)
        {
            double[][] pheromones = new double[numCities][];
            for (int i = 0; i < numCities; i++)
            {
                pheromones[i] = new double[numCities];
            }
            for (int i = 0; i < pheromones.Length; i++)
            {
                for (int j = 0; j < pheromones[i].Length; j++)
                {
                    pheromones[i][j] = 0.01;
                }
            }
            return pheromones;
        }


        private static void UpdatePheromones(double[][] pheromones, List<Ant> ants)
        {
            for (int i = 0; i < pheromones.Length; i++)
            {
                for (int j = i + 1; j < pheromones[i].Length; j++)
                {
                    for (int k = 0; k < ants.Count; k++)
                    {
                        if (ants[k].Trail != null)
                        {
                            double length = Utils.GetPathLength(ants[k].Trail);
                            // length of ant k trail
                            double decrease = (1.0 - rho) * pheromones[i][j];
                            double increase = 0.0;
                            if (EdgeInTrail(i + 1, j + 1, ants[k].Trail))
                            {
                                increase = (Q / length);
                            }

                            pheromones[i][j] = decrease + increase;

                            if (pheromones[i][j] < 0.0001)
                            {
                                pheromones[i][j] = 0.0001;
                            }
                            else if (pheromones[i][j] > 100000.0)
                            {
                                pheromones[i][j] = 100000.0;
                            }

                            pheromones[j][i] = pheromones[i][j];
                        }
                    }
                }
            }
        }

        private static bool EdgeInTrail(int cityX, int cityY, List<Edge> trail)
        {
            return trail.FindIndex(e => e.startVert.Name == cityX && e.endVert.Name == cityY) != -1;
        }
    }
}
