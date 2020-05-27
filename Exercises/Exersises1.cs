using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise2
    {
        private static void Main()
        {
            string firstname, secondname;

            Console.Title = "Шаг 1";
            Console.WriteLine("Назовите свое имя");
            firstname = Console.ReadLine();

            Console.Title = "Шаг 2";
            Console.WriteLine("Назовите свою фамилию");
            secondname = Console.ReadLine();

            Console.WriteLine("Ваше полное имя " + firstname + " " + secondname + ".");

        }
    }
}