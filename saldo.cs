using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babou_no_beck_ta_expulso_da_sessão_nerdola
{
    internal class Carrinho
    {
        public double Pó = 10.99;
        public double Prensado = 10.10;
        public double Haxixe = 30.00;
        public double Crack = 15.20;
        public double Saldo;

        public void Cocaina()
        {
            Saldo += Pó;
        }
        public void Pren()
        {
            Saldo += Prensado;
        }

        public void Hax()
        {
            Saldo += Haxixe;
        }

        public void Pedra()
        {
            Saldo += Crack;
        }

       
        public override string ToString()
        {
            return " \nSeu carrinho atual esta em: "
                   + Saldo.ToString("F2");
        }
    }
}
