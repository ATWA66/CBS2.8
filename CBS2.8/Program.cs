using System;

namespace CBS2._8
{
    //task 2
    internal class Program
    {
        static class MyCLass
        {
            enum Colors 
            {
                blue = 1
              , red = 2
              , green = 3
              , yellow = 4
            }
            static public void Print(string stroka, int color)
            {

                switch (color)
                {
                    case (int)Colors.blue:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        }
                    case (int)Colors.red:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        }
                    case (int)Colors.green:
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                    case (int)Colors.yellow:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("incorrect value");
                            break;
                        }
                }
                Console.WriteLine(stroka);
               Console.ResetColor();
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string & choice color: \n1 - Blue\n2 - Red\n3 - Green\n4 - Yellow");
            MyCLass.Print(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
        }
    }
}
