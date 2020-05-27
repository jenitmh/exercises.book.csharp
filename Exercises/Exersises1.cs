using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise5Console
    {
        private static void Main()
        {
            string year;
            int age, result;

            Console.Write(
                "Введите год рождения: ",
                "Год рождения"
                );
            year = Console.ReadLine();
            result = Int32.Parse(year);

            age = 2020 - result;

            Console.WriteLine("Ваш возраст: " + age);
        }
    }
}