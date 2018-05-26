using System;

namespace Zombie.Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Me = new Person();

            Me.DistanceTraveled = 5;
            Console.WriteLine(Me.DistanceTraveled + " miles traveled");

            Me.Walk(10);
            Console.WriteLine("Distance traveled for 2 minutes = " + Me.DistanceTraveled + " miles traveled");
        }
    }
}
