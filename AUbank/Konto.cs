using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUbank
{
    class Konto
    {
        public static string namn { get; set; }
        public static string pass { get; set; }

        public double saldo { get; set; }
        public string namng { get; set; }

        public Konto(double saldo, string namn)
        {
            this.saldo = saldo;
            this.namng = namn;
        }

        public void ski(Konto frånkonto, double summa)
        {
            frånkonto.saldo -= summa;
            saldo += summa;
        }

        public static string räntaKalk(double x , double y)
        {
            return Math.Round((x = x * y),1).ToString();
        }
    }
}
