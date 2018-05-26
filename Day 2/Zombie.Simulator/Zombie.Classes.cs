using System;

namespace Zombie.Simulator
{
    public class Person
    {
        public int DistanceTraveled{get; set;}

        public void Walk(decimal minutes)
        {
            DistanceTraveled = CalculateWalkDistance(minutes);
        }

        private int CalculateWalkDistance(decimal minutes)
        {
            return ((int) minutes) * 2;
        }

        public Person()
        {
            Console.WriteLine("A new person has been created.");
        }
    }
}
