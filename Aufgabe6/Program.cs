using System;

namespace Aufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            int insertNumber;
            int advisedNumber;
            int counter = 0;

            Random random = new Random();
            advisedNumber = random.Next(101); // random number between 0 and 100

            do
            {
                Console.WriteLine("Bitte geben Sie ein Zahl zwischen 0 bis 100: ");
                insertNumber = Convert.ToInt32(Console.ReadLine());

                if (insertNumber < advisedNumber)
                {
                    Console.WriteLine("Eingegebene Zahl zu klein");
                }
                if (insertNumber > advisedNumber)
                {
                    Console.WriteLine("Eingegebene Zahl zu gross");
                }
                if (insertNumber == advisedNumber)
                {
                    Console.WriteLine("Super! Du hast nur {0} Versuche benötigt", counter);
                }
                counter = counter + 1;
            } while (advisedNumber != insertNumber);

            Console.ReadKey();            
        }
    }
}
