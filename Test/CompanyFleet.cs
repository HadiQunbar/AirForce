using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class CompanyFleet: HilPlane
    {
        private int numPlane; // from 0 to 49
        private Plane[] airplanes;
        public CompanyFleet(int engine,int speed,double weight,String name) : base(engine, speed, weight,"")
        {
            this.numPlane = 0;
            airplanes = new Plane[50];
        }
        public Plane GetPlane(int i)
        {

            return airplanes[i];
        }
        public Plane dateOfNextEngineCheck(int i)
        {

            return airplanes[i];
        }
        public void addPlane(Plane p)
        {
            this.airplanes[numPlane] = p;
            this.numPlane++;
        }
        public int getNumPlane()
        {
            return this.numPlane;
        }


    
    }
}
