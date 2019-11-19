	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace Test
	{
		public class CargoPlane : Plane
		{
			protected int maxWeight;
			public CargoPlane(int engine, int speed, double weight, int maxWeight) : base(engine, speed, weight)
			{
				this.maxWeight = maxWeight;
			}
			public String toString()
			{
				return base.toString() + " max Weight " + maxWeight;
			}
		}

	}
