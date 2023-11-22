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
        public double Prensado = 10.10;
        public double Haxixe = 30.00;
        public double Crack = 15.20;

        public override string ToString()
        {
            return "~Cocaina obstrui vasos nazais ^_^  \n"
                + "R$" + Pó.ToString("F2")
                + "\n*************************************************************"
                + "\n~Prensadinho de 10 A++ ^0^ \n"
                + "R$" + Prensado.ToString("F2") + " p/ grama."
                + "\n************************************************************"
                + "\n~Haxixe Colombiano estoura neuronio amnesia raze a+ X_X  \n"
                + "R$" + Haxixe.ToString("F2") + " p/ grama."
                + "\n************************************************************"
                + "\n~pedra decepciona familia noia  > <  \n"
                + "R$" + Crack.ToString("F2")
                + "\n*************************************************************"
                ;
        }

    }
}
