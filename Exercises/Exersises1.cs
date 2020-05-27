using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise8
    {
        private static void Main()
        {
            string FirstNum, SecondNum;
            int NumA, NumB, Sum;

            Console.Write(
                "Введите первое число: ",
                "Сложение двух чисел"
                );
            FirstNum = Console.ReadLine();
            NumA = Int32.Parse(FirstNum);

            Console.Write(
                "Введите второе число: ",
                "Сложение двух чисел"
                );
            SecondNum = Console.ReadLine();
            NumB = Int32.Parse(SecondNum);
            Sum = NumA + NumB;

            Console.WriteLine();
            Console.WriteLine("Сумма введенных чисел равна " + Sum + ".");
        }
    }
}