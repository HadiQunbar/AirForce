using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class PassangerPlane : Plane 
    {
        protected String type; // סוג ההליקופטר
        protected int NummOfPaasengers;

        public PassangerPlane(int engine, int speed, double
        weight, int NummOfPaasengers,String type) : base(engine, speed, weight)
        {
            this.type = type;
            this.NummOfPaasengers = NummOfPaasengers;
        }

    }
}
