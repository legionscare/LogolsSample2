using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int GovEmployeeStatus = 4;
            string statustatement = "Status of all government emplyoyees:";

            Console.WriteLine("\nIf/else code:");

            if (GovEmployeeStatus == 1)
                Console.WriteLine(statustatement + " Alive");
            else if (GovEmployeeStatus == 2)
                Console.WriteLine(statustatement + " Zombie");
            else if (GovEmployeeStatus == 3)
                Console.WriteLine(statustatement + " Dead");
            else if (GovEmployeeStatus == 4)
                Console.WriteLine(statustatement + " Unknown");

            Console.WriteLine("\nSwitch statement code:");

            switch (GovEmployeeStatus)
            {
                case 1:
                    Console.WriteLine(statustatement + " Alive");
                    break;
                case 2:
                    Console.WriteLine(statustatement + " Zombie");
                    break;
                case 3:
                    Console.WriteLine(statustatement + " Dead");
                    break;
                case 4:
                    Console.WriteLine(statustatement + " Unknown");
                    break;
            }    

            Console.WriteLine("\n");
        }
    }
}
