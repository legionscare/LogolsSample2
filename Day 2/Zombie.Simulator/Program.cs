﻿using System;

namespace Zombie.Simulator
{

    class Person
    {
            public Person()
            {
                Console.WriteLine("A new person has been created.");
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person Me = new Person();
        }
    }
}
