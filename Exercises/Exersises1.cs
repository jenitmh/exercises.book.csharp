using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise9
    {
        private static void Main()
        {
            string number;
            int num, Pnum, Nnum;

            number = Interaction.InputBox("Введите число: ");
            num = Int32.Parse(number);

            Pnum = num - 1; // Предыдущее число от введенного
            Nnum = num + 1; // Следующее число от введенного

            MessageBox.Show("Последовательность трех чисел: " + Pnum + ", " + num + ", " + Nnum + ".");
        }
    }
}