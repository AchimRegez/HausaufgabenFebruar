using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe3
{
    public class Cat:Pet
    {
        private string name { get; set; }

        public void HuntMouse()
        {
            Console.WriteLine("Hunting Mouse");
            Console.ReadKey();
        }
    }
}
