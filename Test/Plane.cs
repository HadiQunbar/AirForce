using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Plane
    {
        protected int engine; // מספר מנועים
        protected int speed; // מהירות מקסימלית
        protected double weight; // משקל בטונות
        private Date date;

        public Plane(int engine, int speed, double weight)
        {
            this.engine = engine;
            this.speed = speed;
            this.weight = weight;
        }
        public Plane(int engine, int speed, double weight,Date date)
        {
            this.engine = engine;
            this.speed = speed;
            this.weight = weight;
            this.date = date;
        }
        public void addDate(Date NewDate)
        {
            this.date = NewDate;

        }
        public Date getDate()
        {
            return this.date;

        }
        public double getWeight()
        {
            return this.weight;
        }
        
        public String toString()
        {
            return  "engine" +engine + " speed " +speed + "weight" +weight;

        }
    }
}
