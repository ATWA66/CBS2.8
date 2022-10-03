using System;
//task5,4
namespace ConsoleApp61
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            DateTime now = DateTime.Now;
            TimeSpan next;
            if (birthday < DateTime.Now)
            {
                Console.WriteLine(birthday);
                birthday = birthday.AddYears(now.Year - birthday.Year + 1);
                Console.WriteLine(birthday);
                next = birthday - now;
            }
            else
                next = birthday - DateTime.Now;
            Console.WriteLine(next.Days);
        }
    }
}
//task4
//MSDN: Упаковка-преобразование и распаковка-преобразование (Руководство по программированию на c#)-  описывает преобразования типов данных
//SDN: Типы перечислений enum (Руководство по программированию на C#) - описывает устройство enum
//MSDN: DateTime – структура- описываеи оьширную структуру дататайм со всеми ее методами свойствами конструкторами...
