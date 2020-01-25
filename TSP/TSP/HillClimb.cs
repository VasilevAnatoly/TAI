using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbor
{
    class HillClimb
    {
        static Random rnd = new Random();

        public static List<Edge> Algorithm(int maxIterations, List<Edge> edges, List<Vertex> vertexes)
        {
            bool flag = true;

            int counter = 0;

            List<Vertex> currVertexes = new List<Vertex>(vertexes);
            List<Edge> localEdges = new List<Edge>(edges);

            //List<Edge> gamHCEdges = NewNearestNeighbour.Algorithm(rnd.Next(0, currVertexes.Count), edges, currVertexes, true);

            var randomStartVert = rnd.Next(0, currVertexes.Count);
            List<Edge> gamHCEdges =  Utils.GetPath(Utils.GetRandomVertexes(randomStartVert + 1, currVertexes), localEdges);
            double gamHCEnergy = Utils.GetPathLength(gamHCEdges);

            while (flag && counter < maxIterations)
            {
                bool moved = false;

                for (int i = 0; i < vertexes.Count; i++)
                {
                    if (counter >= maxIterations)
                        break;

                    int j = 0;
                    while ((j = rnd.Next(0, vertexes.Count)) == i);

                    var tempVert = currVertexes[i];
                    currVertexes[i] = currVertexes[j];
                    currVertexes[j] = tempVert;

                    List<Edge> gamHCCur = Utils.GetPath(currVertexes, edges);
                    double currTrailPath = Utils.GetPathLength(gamHCCur);

                    if (currTrailPath < gamHCEnergy)
                    {
                        gamHCEdges = gamHCCur;
                        gamHCEnergy = currTrailPath;
                        moved = true;
                        break;
                    }

                    counter++;
                }

                if (!moved)
                    flag = false;
            }

            return gamHCEdges;
        }
    }
}
