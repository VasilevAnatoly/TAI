using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NearestNeighbor
{
    class Annealing
    {
        static Random rnd = new Random();
        static Random rndChance = new Random();

        public static List<Edge> Algorithm(int maxSteps, double alpha, double maxTemp, double minTemp, List<Edge> edges, List<Vertex> vertexes)
        {
            List<Vertex> currVertexes = new List<Vertex>(vertexes);

            // List<Edge> gamAnnealingEdges = NewNearestNeighbour.Algorithm(rnd.Next(0, currVertexes.Count), edges, currVertexes, true);

            List<Edge> gamAnnealingEdges = Utils.GetPath(Utils.GetRandomVertexes(rnd.Next(0, currVertexes.Count) + 1, currVertexes), edges);

            double gamAnnealingEnergy = Utils.GetPathLength(gamAnnealingEdges);

            while (maxTemp > minTemp && maxSteps > 0)
            {
                //получили индексы вершин, которые хотим поменять местами
                int firstVert = rnd.Next(0, currVertexes.Count);
                int secondVert;
                while ((secondVert = rnd.Next(0, currVertexes.Count)) == firstVert);

                var tempVert = currVertexes[firstVert];
                currVertexes[firstVert] = currVertexes[secondVert];
                currVertexes[secondVert] = tempVert;

                List<Edge> gamTempCur = Utils.GetPath(currVertexes, edges);

                //считаем разность
                double currEnergy = gamTempCur.Sum(e => e.Cost);

                if (currEnergy < gamAnnealingEnergy)
                {
                    gamAnnealingEdges = Utils.CopyEdges(gamTempCur);
                }
                else
                {
                    double P = Math.Exp(-(currEnergy - gamAnnealingEnergy) / maxTemp);

                    if (P >= rndChance.NextDouble())
                    {
                        gamAnnealingEdges = Utils.CopyEdges(gamTempCur);
                    }
                }

                gamAnnealingEnergy = Utils.GetPathLength(gamAnnealingEdges);
                maxTemp *= alpha;
                maxSteps--;
            }

            return gamAnnealingEdges;
        }   
    }
}
