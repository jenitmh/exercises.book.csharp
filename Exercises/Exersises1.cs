using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise2
    {
        private static void Main()
        {
            string firstname, age;
            int year;

            Console.Title = "Шаг 1";
            Console.Write("Введите свое имя: ");
            firstname = Console.ReadLine();

            Console.Title = "Шаг 2";
            Console.Write("Введите свой возраст: ");
            age = Console.ReadLine();
            year = Int32.Parse(age);

            Console.WriteLine();
            Console.WriteLine("Ваше полное имя " + firstname);
            Console.WriteLine("Ваш возраст" + " " + year + ".");

        }
    }
}