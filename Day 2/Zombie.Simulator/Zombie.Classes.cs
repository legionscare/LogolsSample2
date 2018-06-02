using System;

namespace Zombie.Simulator
{
    public abstract class Person
    {
        public int DistanceTraveled{get; set;}

        public virtual void Walk(decimal minutes)
        {
            DistanceTraveled = CalculateWalkDistance(minutes);
        }

        public virtual int CalculateWalkDistance(decimal minutes)
        {
            return ((int) minutes) * 10;
        }

        public Person()
        {
            Console.WriteLine("A new person has been created.");
        }
    }

    public sealed class Human : Person
    {
        public Human()
        {
            Console.WriteLine("A new human has arrived.");
        }

        public void Run(decimal minutes)
        {
            DistanceTraveled = CalculateWalkDistance((int) minutes) * 5;
        }
    }

    public sealed class Zombie : Person
    {
        public Zombie()
        {
            Console.WriteLine("A new zombie has arrived.");
        }

        public override int CalculateWalkDistance(decimal minutes)
        {
            return ((int) minutes) / 2;
        }
    }
}
