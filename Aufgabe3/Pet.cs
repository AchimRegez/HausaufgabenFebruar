using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe3
{
    public class Pet
    {
        public int nrOfLegs { get; set; }
        public int age { get; set; }


        public Pet(int numberOfLegsPet, int agePet)
        {
            this.nrOfLegs = numberOfLegsPet;
            this.age = agePet;
        }

        public void Feed()
        {
            Console.WriteLine("Mampf, Mampf!!!"); 
        }

        public Pet()
        {

        }
    }


}
