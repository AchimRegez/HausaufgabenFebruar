using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe4
{
    class Vehicle
    {
        private static int nrOfObjects { get; set; }
        public string brand { get; private set; }
        private int coveredDistance { get; set; }

        public Vehicle(string brandVehicle)
        {
            this.brand = brandVehicle;
            nrOfObjects += 1;
        }

        public bool Drive(int distance)
        {
            this.coveredDistance += distance;
            return true;
        }

        public static int GetNrOfCreatedObjects()
        {            
            return nrOfObjects;
        }
    }
}
