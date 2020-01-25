using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNeighbor
{
    class Ant
    {
        public int Name { get; set; }
        public List<Edge> Trail { get; set; }
        public int TrailLength { get; set; }

        public Ant(int name)
        {
            Name = name;
            Trail = new List<Edge>();
            TrailLength = 0;
        } 
    }
}
