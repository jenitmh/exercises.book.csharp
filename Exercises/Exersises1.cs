using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise9
    {
        private static void Main()
        {
            string firstnumber, secondnumber;
            int numA, numB, sum, dif;

            Console.Write(
                "Ведите первое число: ",
                "Сумма и разность чисел"
                );
            firstnumber = Console.ReadLine();
            numA = Int32.Parse(firstnumber);

            Console.Write(
                "Введите второе число: ",
                "Сумма и разность чисел"
                );
            secondnumber = Console.ReadLine();
            numB = Int32.Parse(secondnumber);

            sum = numA + numB;
            dif = numA - numB;

            Console.WriteLine("Сумма введенных чисел равна: " + sum + "\n" + "Разность введенных чисел равна: " + dif);
        }
    }
}