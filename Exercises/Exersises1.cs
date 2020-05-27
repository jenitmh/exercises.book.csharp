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

            year = Interaction.InputBox(
                "Введите год рождения: ",
                "Год рождения"
                );
            result = Int32.Parse(year);
            age = 2020 - result;

            MessageBox.Show("Ваш возраст: " + age);
        }
    }
}