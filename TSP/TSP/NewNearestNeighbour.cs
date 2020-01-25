using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbor
{
    class NewNearestNeighbour
    {
        public static Random rnd = new Random();

        public static List<Edge> Algorithm(int startIdx, List<Edge> edges, List<Vertex> vertexes, bool withRandom = false)
        {
            List<Edge> gamiltonEdges = new List<Edge>();

            int minEdgeCost = int.MaxValue;
            Vertex currVert = null;
            Edge currEdge = null;

            Vertex startVert = vertexes[startIdx];
            currVert = startVert;

            do
            {
                //находим ребра, где стартовой вершиной является выбранная, а конечная вершина еще не посещена
                var startEdges = edges.Where(e => e.startVert.Name == currVert.Name && !e.endVert.IsVisited).ToList();

                if (startEdges.Count > 0)
                {
                    if (startEdges.Count > 1)
                    {
                        if (withRandom)
                        {
                            int idx = rnd.Next(0, startEdges.Count);
                            currEdge = startEdges[idx];
                            minEdgeCost = startEdges[idx].Cost;
                        }
                        else
                        {
                            foreach (var e in startEdges)
                            {
                                bool isVis = e.endVert.IsVisited;
                                bool isStart = e.endVert.Name == startVert.Name;

                                //если конечная вершина - не начальная и еще не была посещена
                                if (!isStart && !isVis || isStart && vertexes.Count(v => !v.IsVisited) == 1)
                                {
                                    if (e.Cost < minEdgeCost)
                                    {
                                        minEdgeCost = e.Cost;
                                        currEdge = e;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        minEdgeCost = startEdges[0].Cost;
                        currEdge = startEdges[0];
                    }
                    currVert = currEdge.endVert;
                    currEdge.endVert.IsVisited = true;

                    //добавляем ребро в ребра, образующие гамильтонов цикл
                    gamiltonEdges.Add(currEdge);
                    minEdgeCost = int.MaxValue;
                }
                else
                {
                    currVert = null;
                    break;
                }
            }
            while (currVert != null && currVert != startVert);

            vertexes.ForEach(v =>
            {
                v.IsVisited = false;
            });

            return gamiltonEdges;
        }
    }
}
