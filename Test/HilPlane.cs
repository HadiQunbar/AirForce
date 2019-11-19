using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class HilPlane : Plane
    {
        protected String type; // סוג ההליקופטר
        public HilPlane(int engine, int speed, double weight, String type) : base(engine,speed, weight)
        {
            this.type = type;
        }
        public String getName()
        {
            return this.type;
        }
        public String toString()
        {
            return base.toString() + " type "+type;
        }
    }
}
