using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNeighbor
{
    public static class NearestNeighbor
    {
        public static string Algorithm(Vertex startVert, List<Edge> listEdge, List<Vertex> vertexes, List<Edge> gamiltonEdges, ref int localLength)
        {
            int minCost = int.MaxValue;
            Vertex curVert = null;
            Edge gamEdge = null;
            int startName = startVert.Name;
            int numbVert = startVert.Name;

            do
            {
                //находим ребра, где стартовой вершиной является выбранная
                var startEdges = listEdge.Where(e => e.startVert.Name == numbVert).ToList();

                if (startEdges.Count > 0)
                {
                    //в цикле по всем найденным ребрам ищем ребро с минимальным весом и запоминаем его
                    foreach (var e in startEdges)
                    {
                        bool isVis = e.endVert.IsVisited;
                        bool isStart = e.endVert.Name == startName;

                        //если конечная вершина - не начальная и еще не была посещена
                        if (!isStart && !isVis)
                        {
                            if (e.Cost < minCost)
                            {
                                minCost = e.Cost;
                                gamEdge = e;
                            }
                        }
                        else
                        {
                            //иначе, если конечная вершина - начальная и только она осталась непосещенной
                            if (isStart && vertexes.Count(v => !v.IsVisited) == 1)
                            {
                                if (e.Cost < minCost)
                                {
                                    minCost = e.Cost;
                                    gamEdge = e;
                                }
                            }
                        }
                    }
                    //теперь текущая вершина - конечная вершина ребра
                    numbVert = gamEdge.endVert.Name;
                    curVert = gamEdge.endVert;
                    gamEdge.endVert.IsVisited = true;

                    //добавляем ребро в ребра, образующие гамильтонов цикл
                    gamiltonEdges.Add(gamEdge);
                    minCost = int.MaxValue;
                }
                else
                {
                    curVert = null;
                    localLength = Int32.MaxValue;
                    break;
                }
            } while (curVert != null && curVert.Name != startName);

            if (localLength != Int32.MaxValue)
            {
                string str = gamiltonEdges.Aggregate("", (current, ed) => current + (ed.startVert.Name + " -->> "));
                localLength = gamiltonEdges.Sum(e => e.Cost);
                str += startName;
                return str;
            }
            else
            {
                return $"Для вершины {startVert.Name} невозможно построить гамильтонов цикл!";
            }
        }
    }
}
