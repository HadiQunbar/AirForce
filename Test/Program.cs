using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyFleet compAirplanes1 = new CompanyFleet(0,0,0,"");
            HilPlane NewHil1 = new HilPlane(1,150,300.5,"Helicopter1");
            CargoPlane newCargo1 = new CargoPlane(2,170,600,1000,"CargoPlan1");
            compAirplanes1.addPlane(NewHil1);
            compAirplanes1.addPlane(newCargo1);

            //********************************************************************
            Plane P1 = new Plane(2,400,130);
            CargoPlane P2 = new CargoPlane(3,200,400,450, "CargoPlan2");
            HilPlane P3 = new HilPlane(2,230,290,"Helicopter2");
            PassangerPlane P4 = new PassangerPlane(1,300,250,80, "PassangerPlane1");

            Console.WriteLine(P1);// will print test.P1
            Console.WriteLine(P2);// will print test.P1 becasue didnt use function toString
            Console.WriteLine(P3.toString());// will print normal
            Console.WriteLine(P4.toString());//will print normal
            //*********************************************************************

            HilPlane NewHil2 = new HilPlane(2, 150, 300.5, "Helicopter3");
            CargoPlane newCargo2 = new CargoPlane(2, 170, 600, 1000, "CargoPlan3");
            HilPlane NewHil3 = new HilPlane(5, 150, 3021.5, "Helicopter4");
            CargoPlane newCargo3 = new CargoPlane(3, 278, 600, 1000, "CargoPlan4");
            HilPlane NewHil4 = new HilPlane(1, 150, 300.5, "Helicopter5");
            CargoPlane newCargo4 = new CargoPlane(2, 1234, 600, 1000, "CargoPlan5");
            HilPlane NewHil5 = new HilPlane(1, 150, 300.5, "Helicopter6");
            CargoPlane newCargo5 = new CargoPlane(2, 170, 899, 1000, "CargoPlan6");
            compAirplanes1.addPlane(NewHil2);
            compAirplanes1.addPlane(newCargo2);
            compAirplanes1.addPlane(NewHil3);
            compAirplanes1.addPlane(newCargo3);
            compAirplanes1.addPlane(NewHil4);
            compAirplanes1.addPlane(newCargo4);
            compAirplanes1.addPlane(NewHil5);
            compAirplanes1.addPlane(newCargo5);
            
            int Biggest = 0;
            Plane BiggestName;
            BiggestName = compAirplanes1.GetPlane(0);
            BiggestName = compAirplanes1.GetPlane(0);
            for (int i = 1; i<compAirplanes1.getNumPlane(); i++)
            {
                if (compAirplanes1.GetPlane(i).getWeight() >Biggest )
                {
                    BiggestName = compAirplanes1.GetPlane(i);
                }
            }
            Console.WriteLine("The Haviest Plane is : ");
            Console.WriteLine(BiggestName.toString());
            //********************************************************************
            Date NewDate1 = new Date(4,12,1997);
            compAirplanes1.GetPlane(0).addDate(NewDate1);







        }
    }
}
