using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] GovEmployeeStatus = new int[] {1, 3, 4, 2, 3};
            string statustatement = "Status of all government emplyoyees:";

            Console.WriteLine("\nIf/else code:");

            for (int counter = 0; counter < GovEmployeeStatus.Length; counter++)
            {
                if (GovEmployeeStatus[counter] == 1)
                    Console.WriteLine(statustatement + " Alive");
                else if (GovEmployeeStatus[counter] == 2)
                    Console.WriteLine(statustatement + " Zombie");
                else if (GovEmployeeStatus[counter] == 3)
                    Console.WriteLine(statustatement + " Dead");
                else if (GovEmployeeStatus[counter] == 4)
                    Console.WriteLine(statustatement + " Unknown");
            }

            Console.WriteLine("\nSwitch statement code:");

            for (int counter = 0; counter < GovEmployeeStatus.Length; counter++)
            {
                switch (GovEmployeeStatus[counter])
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
            }    

            Console.WriteLine("\n");
        }
    }
}
