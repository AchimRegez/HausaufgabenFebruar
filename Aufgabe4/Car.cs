using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe4
{
    class Car : Vehicle
    {
        private double fuelConsumption { get; set; }
        private double fuelCapacity { get; set; }
        private double fuelLevel { get; set; }

        public Car(string brandCar, double consumptionCar, double fuelCapacityCar):base(brandCar)
        {
            this.fuelConsumption = consumptionCar;
            this.fuelLevel = fuelCapacityCar;
        }

        public bool Refuel()
        {

        }

        public bool Drive()
        {

        }
    }
}
