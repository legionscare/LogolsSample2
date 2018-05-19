using System;

namespace Exercise_1
{
    class Program
    {
        private static string ZombieStatusIfElseMethod(int statustype)
        {
                if (statustype == 1)
                    return ("Alive");
                else if (statustype == 2)
                    return ("Zombie");
                else if (statustype == 3)
                    return ("Dead");
                else if (statustype == 4)
                    return ("Unknown");
                
                return "NULL";
        }

        private static string ZombieStatusSwitchMethod(int statustype)
        {
                switch (statustype)
                {
                    case 1:
                        return ("Alive");
                        break;
                    case 2:
                        return ("Zombie");
                        break;
                    case 3:
                        return ("Dead");
                        break;
                    case 4:
                        return ("Unknown");
                        break;
                }
                return "NULL";
        }

        static void Main(string[] args)
        {
            int[] GovEmployeeStatus = new int[] {1, 3, 4, 2, 3};
            string[] GovviesNames = new string[] {"Bobby", "JR", "Sue Ellen", "Ray Ray", "Gandolf"};
            string statustatement = "Status of government emplyoyee ";

            Console.WriteLine("\nIf/else code:");

            for (int counter = 0; counter < GovEmployeeStatus.Length; counter++)
            {
                    Console.WriteLine(statustatement + GovviesNames[counter] +": " + ZombieStatusIfElseMethod(GovEmployeeStatus[counter]));
            }

            Console.WriteLine("\nSwitch statement code:");

            for (int counter = 0; counter < GovEmployeeStatus.Length; counter++)
            {
                    Console.WriteLine(statustatement + GovviesNames[counter] +": " + ZombieStatusSwitchMethod(GovEmployeeStatus[counter]));
            }

            Console.WriteLine("\n");
        }
    }
}
