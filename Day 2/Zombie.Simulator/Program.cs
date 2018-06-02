using System;

namespace Zombie.Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Me = new Human();

            Me.DistanceTraveled = 5;
            Console.WriteLine(Me.DistanceTraveled + " miles traveled");

            Me.Walk(2);
            Console.WriteLine("Walk distance traveled for 2 minutes = " + Me.DistanceTraveled + " miles traveled");

            Me.Run(2);
            Console.WriteLine("Run distance traveled for 2 minutes = " + Me.DistanceTraveled + " miles traveled");

            Console.WriteLine("");

            Zombie Deadite = new Zombie();

            Deadite.DistanceTraveled = 15;
            Console.WriteLine(Deadite.DistanceTraveled + " miles traveled");

            Deadite.Walk(2);
            Console.WriteLine("Walk distance traveled for 2 minutes = " + Deadite.DistanceTraveled + " miles traveled");
        }
    }
}
