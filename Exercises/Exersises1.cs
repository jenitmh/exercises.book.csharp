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

            firstname = Interaction.InputBox(
                "Введите свое имя:",
                "Шаг 1"
                );
            age = Interaction.InputBox(
                "Введите свой возраст:",
                "Шаг 2"
                );
            year = Int32.Parse(age);

            MessageBox.Show("Ваше имя: " + firstname + "\n" + "Ваш возраст: " + year);
        }
    }
}