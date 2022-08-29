using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartments
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F1());
            //При запуске начальной формы проверяется, существуют ли нужные файлы, и если нет, они создаются.
            if (File.Exists(Application.StartupPath + @"\Список клиентов.txt") == false)
            {
                File.Create(Application.StartupPath + @"\Список клиентов.txt").Close();
            }
            if(File.Exists(Application.StartupPath + @"\Rewrite.txt") == false)
            {
                File.Create(Application.StartupPath + @"\Rewrite.txt").Close();
            }
        }
    }
}
