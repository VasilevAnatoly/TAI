using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGUI
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
