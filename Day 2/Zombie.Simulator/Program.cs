using System;

namespace Zombie.Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Me = new Human();

            Me.SetDistanceTraveled(5);
            Console.WriteLine(Me.GetDistanceTraveled() + " miles traveled");

            Me.Walk(2);
            Console.WriteLine("Walk distance traveled for 2 minutes = " + Me.GetDistanceTraveled() + " miles traveled");

            Me.Run(2);
            Console.WriteLine("Run distance traveled for 2 minutes = " + Me.GetDistanceTraveled() + " miles traveled");

            Console.WriteLine("");

            Zombie Deadite = new Zombie();

            Deadite.DistanceTraveled = 15;
            Console.WriteLine(Deadite.DistanceTraveled + " miles traveled");

            Deadite.Walk(2);
            Console.WriteLine("Walk distance traveled for 2 minutes = " + Deadite.DistanceTraveled + " miles traveled");
        }
    }
}
