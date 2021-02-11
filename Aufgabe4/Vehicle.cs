using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe4
{
    class Vehicle
    {
        private int nrOfObjects { get; set; }
        private string brand { get; set; }
        private int coveredDistance { get; set; }

        public Vehicle(string brandVehicle)
        {
            this.brand = brandVehicle;
        }

        public bool Drive()
        {
            this.coveredDistance // ?????
            return true;
        }

        public int GetNrOfCreatedObjects()
        {
            return nrOfObjects;
        }
    }
}
