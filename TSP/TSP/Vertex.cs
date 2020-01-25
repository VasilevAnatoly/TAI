namespace NearestNeighbor
{
    public class Vertex
    {
        public int Name { get; set; }
        public bool IsVisited { get; set; }

        public Vertex(int name)
        {
            Name = name;
        }

        public Vertex(Vertex init)
        {
            Name = init.Name;
            IsVisited = false;
        }
    }
}
