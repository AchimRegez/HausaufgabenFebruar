using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe4
{
    class Bicycle : Vehicle
    {
        private bool hasSuspension { get; set; }
        private int averageSpeed { get; set; }


        public Bicycle(string brandBicycle, bool hasSuspensionBicycle, int averageSpeedBicycle):base(brandBicycle)
        {            
            this.hasSuspension = hasSuspensionBicycle;
            this.averageSpeed = averageSpeedBicycle;
        }
    }
}
