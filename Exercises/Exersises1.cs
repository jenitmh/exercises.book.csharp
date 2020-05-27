using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace exercises.book.csharp
{
    class Exercise1
    {
        private static void Main()
        {

            string firstname = Interaction.InputBox(
                "Назовите свое имя",
                "Шаг 1"
                );
            string secondname = Interaction.InputBox(
                "Назовите свою фамилию",
                "Шаг 2"
                );
            MessageBox.Show("Ваше полное имя " + firstname + " " + secondname + ".");

        }
    }
}