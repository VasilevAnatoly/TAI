using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestNeighbor
{
    class Utils
    {
        private static Random rnd = new Random();

        public static string GetPathString(List<Edge> gamiltonEdges)
        {
            string str = gamiltonEdges.Aggregate("", (current, ed) => current + (ed.startVert.Name + " -->> "));
            str += gamiltonEdges[0].startVert.Name;
            return str;
        }

        public static int GetPathLength(List<Edge> gamiltonEdges)
        {
            return gamiltonEdges.Sum(e => e.Cost);
        }

        public static List<Edge> GetPath(List<Vertex> vertexes, List<Edge> edges)
        {
            List<Edge> gamiltonEdges = new List<Edge>();

            for (int i = 0; i < vertexes.Count; i++)
            {
                Edge currEdge = null;
                if (i + 1 < vertexes.Count)
                {
                    currEdge = edges.FirstOrDefault(e => e.startVert.Name == vertexes[i].Name && e.endVert.Name == vertexes[i + 1].Name);
                }
                else
                {
                    currEdge = edges.FirstOrDefault(e => e.startVert.Name == vertexes[i].Name && e.endVert.Name == vertexes[0].Name);
                }
                if (currEdge == null)
                {
                    var a = 0;
                }
                gamiltonEdges.Add(currEdge);
            }

            if (gamiltonEdges.Any(e => e == null))
            {
                var a = 0;
            }
            return gamiltonEdges;
        }

        public static List<Edge> CopyEdges(List<Edge> edges)
        {
            return new List<Edge>(edges.Select(ed => new Edge(ed.startVert, ed.endVert, ed.Cost)));
        }

        public static List<Vertex> GetRandomVertexes(int startVertexName, List<Vertex> vertexes)
        {
            for (int i = 0; i < vertexes.Count; ++i) // Fisher-Yates shuffle
            {
                int r = rnd.Next(i, vertexes.Count);
                Vertex tmp = vertexes[r]; vertexes[r] = vertexes[i]; vertexes[i] = tmp;
            }

            int idx = vertexes.FindIndex(v => v.Name == startVertexName);
            Vertex temp = vertexes[0];
            vertexes[0] = vertexes[idx];
            vertexes[idx] = temp;

            return vertexes;
        }

        public static int DistanceBetweenTrails(List<Edge> firstTrail, List<Edge> secondTrail)
        {
            List<Vertex> firstPath = firstTrail.Select(t => t.startVert).ToList();
            List<Vertex> secondPath = secondTrail.Select(t => t.startVert).ToList();

            List<bool> difference = new List<bool>();

            for (int i = 0; i < firstPath.Count; i++)
            {
                if (firstPath[i].Name != secondPath[i].Name)
                {
                    difference.Add(true);
                }
                else
                {
                    difference.Add(false);
                }
            }

            return difference.Count(f => f);
        }
    }
}
