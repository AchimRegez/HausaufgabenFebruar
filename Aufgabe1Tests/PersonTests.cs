using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aufgabe1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe1.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest()
        {
            Person felix = new Person("Felix", true);
            Assert.AreEqual(felix.GetType(), typeof(Person));
            Assert.IsInstanceOfType(felix, typeof(Person));
        }

        [TestMethod()]
        public void PersonTest1()
        {
            Person franz = new Person("Franz", true);
            Person kevin = new Person("Kevin", true, franz);
            Assert.AreEqual(kevin.GetType(), typeof(Person));
            Assert.IsInstanceOfType(kevin, typeof(Person));
        }

        [TestMethod()]
        public void PersonTest2()
        {
            Person franz = new Person("Franz", true);
            Person clara = new Person("Clara", false);
            Person nicole = new Person("Nicole", false, franz, clara);
            Assert.AreEqual(nicole.GetType(), typeof(Person));
            Assert.IsInstanceOfType(nicole, typeof(Person));
        }

        [TestMethod()]
        public void AddChildTest()
        {
            Person fritz = new Person("Fritz", true);
            Person carola = new Person("Carola", false);
            try
            {
                carola.AddChild(fritz);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        public void HasFatherTest()
        {
            Person manuel = new Person("Manauel", true);
            Assert.IsTrue(manuel.HasFather());
        }

        [TestMethod()]
        public void HasMotherTest()
        {
            Person miriam = new Person("Miriam", false);
            Assert.IsTrue(miriam.HasMother());
        }
    }
}