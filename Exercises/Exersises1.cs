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

            FirstNum = Interaction.InputBox(
                "Введите первое число: ",
                "Сложение двух чисел"
                );
            NumA = Int32.Parse(FirstNum);

            SecondNum = Interaction.InputBox(
                "Введите второе число: ",
                "Сложение двух чисел"
                );
            NumB = Int32.Parse(SecondNum);

            Sum = NumA + NumB;

            MessageBox.Show("Сумма введенных чисел равна " + Sum);
        }
    }
}