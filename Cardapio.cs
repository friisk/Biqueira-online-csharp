using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babou_no_beck_ta_expulso_da_sessão_nerdola
{
    internal class Cardapio
    {
        public double Pó = 10.99;
        public double Prensado = 5.10;
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

        public Cardapio(double sld) //sld == saldo
        {
            Saldo = sld;
        }
        public override string ToString()
        {
            return "~Cocaina obstrui vasos nazais ^_^  \n"
                + "R$" + Pó
                + "\n*************************************************************"
                + "\n~Prensadinho de 10 A++ ^0^ \n"
                + "R$" + Prensado
                + "\n************************************************************"
                + "\n~Haxixe Colombiano estoura neuronio amnesia raze a+ X_X  \n"
                + "R$" + Haxixe
                + "\n************************************************************"
                + "\n~pedra decepciona familia noia  > <  \n"
                + "R$" + Crack
                + "\n*************************************************************"
                + " \nSeu saldo atual esta em: "
                + Saldo;
        }

    }
}
