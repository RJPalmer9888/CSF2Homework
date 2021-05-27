using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        public float LoadCapacityLbs { get; set; }

        public Truck(string make, string model, int year, float weight, float loadCapacityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        //methods
        public override string ToString()
        {
            return base.ToString() +
                "Load Capacity: " + LoadCapacityLbs + "lbs";
        }
    }
}

