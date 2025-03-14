using NekrylovDB2;
using System;
using System.Windows.Forms;

namespace MaterialFormExample
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск главной формы напрямую
            Application.Run(new MainForm(1)); // Передаем роль пользователя (например, 1 для администратора)
        }
    }
}