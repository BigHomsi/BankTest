using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUbank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Konto konto1;
        public static Konto konto2;


        [STAThread]
        static void Main()
        {
            konto1 = new Konto(1000, "Lönekonto");
            konto2 = new Konto(5000, "Sparkonto");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
