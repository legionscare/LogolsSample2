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

    public virtual class Human : IPerson
    {
        public virtual decimal DistanceTraveled {get; set;} 

        public Human()
        {
            Console.WriteLine("The new person is a human.");
        }
        
        public virtual int CalculateWalkDistance(decimal minutes)
        {
            return ((int) minutes) * 10;
        }
        public virtual void Walk(decimal minutes)
        {
            DistanceTraveled = CalculateWalkDistance(minutes);
        }
        public void Run(decimal minutes)
        {
            IPerson.DistanceTraveled = CalculateWalkDistance((int) minutes) * 5;
        }
    }

    public sealed class Zombie : Person
    {
        public Zombie()
        {
            Console.WriteLine("The new person is a zombie.");
        }

        public override int CalculateWalkDistance(decimal minutes)
        {
            return ((int) minutes) / 2;
        }
    }

    public interface IPerson
    {
        decimal DistanceTraveled {get; set;}

        void Walk(decimal minutes);
    
        void Run(decimal minutes);

        int CalculateWalkDistance(decimal minutes); 
    }
}
