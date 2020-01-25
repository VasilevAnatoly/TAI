namespace NearestNeighbor
{
    public class Edge
    {
        public Vertex startVert, endVert;
        private int _cost;

        public Edge(Vertex start, Vertex end, int cost)
        {
            startVert = start;
            endVert = end;
            _cost = cost;
        }

        public int Cost
        {
            get { return _cost; }
        }

        public static Edge CopyEdge(Edge init)
        {
            return new Edge(init.startVert, init.endVert, init.Cost);
        }
    }
}
