using System;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Vehicle.GetNrOfCreatedObjects());

            Car c1 = new Car("Ferrari", 0.5, 50);
            c1.Refuel(60);
            Car c2 = new Car("Peugeo", 0.05, 40);
            c1.Refuel(40);
            Car c3 = new Car("BMW", 0.1, 45);
            c1.Refuel(40);
            Bicycle b1 = new Bicycle("Villiger", false, 15);
            Bicycle b2 = new Bicycle("BMW", true, 23);

            Console.WriteLine(Vehicle.GetNrOfCreatedObjects());

            Race race = new Race();
            race.AddVehicle(c1);
            race.AddVehicle(c2);
            race.AddVehicle(c3);
            race.AddVehicle(b1);
            race.AddVehicle(b2);

            race.StartRace(300);
            race.StartRace(400);

            Console.ReadLine();
        }
    }
}
