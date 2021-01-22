using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arcanoid
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Launcher first = new Launcher();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(7);
            first.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new Arkanoid());
            
        }
    }
}
