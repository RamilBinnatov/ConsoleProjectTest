using Service.Helpers;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Select one option");
            Helper.WriteConsole(ConsoleColor.Yellow, "1 - Create library, 2 - Get library, 3 - Update library, 4 - Delet library");

            while (true)
            {
                Selectoption: string selectOption = Console.ReadLine();
                int selectTrueoption;
                bool isSelectOption = int.TryParse(selectOption, out selectTrueoption);

                if (isSelectOption)
                {
                    switch (selectTrueoption)
                    {
                        case 1:
                            Console.WriteLine(selectTrueoption);
                            break;
                        case 2:
                            Console.WriteLine(selectTrueoption);
                            break;
                        case 3:
                            Console.WriteLine(selectTrueoption);
                            break;
                        case 4:
                            Console.WriteLine(selectTrueoption);
                            break;
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select true option");
                            break;
                            
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.DarkCyan, "Select true option");
                    goto Selectoption;
                }
            }
        } 
    }
}
