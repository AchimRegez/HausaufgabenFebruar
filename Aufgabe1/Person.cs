using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe1
{
    public class Person
    {
        // Properties
        private string name { get; set; }
        private bool isMale { get; set; }


        // Konstruktor
        public Person(string namePerson, bool isMalePerson)
        {
            this.name = namePerson;
            this.isMale = isMalePerson;
        }

        public Person(string namePerson, bool isMalePerson, Person father)
        {
            this.name = namePerson;
            this.isMale = isMalePerson;
        }

        public Person(string namePerson, bool isMalePerson, Person father, Person mother)
        {
            this.name = namePerson;
            this.isMale = isMalePerson;
        }


        // Methods
        public void AddChild(Person child)
        {
            // Gibt keinen Wert zurück, darum wurde das Unit Testing mit try und catch getestet
        }

        public bool HasFather()
        {
            return true;
        }

        public bool HasMother()
        {
            return true;
        }

    }
}
