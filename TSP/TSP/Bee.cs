using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestNeighbor
{
    public class Bee
    {
        public int status; // 0 = inactive, 1 = active, 2 = scout
        public List<Edge> trail; // problem-specific. a path of cities.
        public double totalDistance; // smaller values are better. total distance of path.
        public int numberOfVisits;

        public Bee(int status, List<Edge> trail, double totalDistance, int numberOfVisits)
        {
            this.status = status;
            this.trail = trail;
            this.totalDistance = totalDistance;
            this.numberOfVisits = numberOfVisits;
        }
    }
}
