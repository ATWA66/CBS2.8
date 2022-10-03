using System;
//task3
namespace ConsoleApp60
{
    internal class Program
    {
        enum Post : Int32
        {
             jun = 160,
             mid= 100,
             sen = 80,
        }
        static class Accountant
        {
            public static bool AskForBonus(Post worker, int hours)
            {
                if  ((int)worker > hours)
                    return false;
                return true;
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your post \n1 - jun\n2 - mid\n3 - sen");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.WriteLine("Enter hours");
                        Console.WriteLine("Bonus - " + Accountant.AskForBonus(Post.jun, Convert.ToInt32(Console.ReadLine())));
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Enter hours");
                        Console.WriteLine("Bonus - " + Accountant.AskForBonus(Post.mid, Convert.ToInt32(Console.ReadLine())));
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Enter hours");
                        Console.WriteLine("Bonus - " + Accountant.AskForBonus(Post.sen, Convert.ToInt32(Console.ReadLine())));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("an error occured");
                        break;
                    }
            }
        }
    }
}
