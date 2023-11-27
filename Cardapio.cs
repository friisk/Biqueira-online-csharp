using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babou_no_beck_ta_expulso_da_sessão_nerdola
{
    internal class Cardapio
    {
        private Dictionary <string, double> PreçoDosItens = new Dictionary <string, double>();
        public Cardapio()
        {
            PreçoDosItens.Add("Espada Draconica ", 1000.0);
            PreçoDosItens.Add("Elixir", 50.34);
            PreçoDosItens.Add("Arco", 200.34);
            PreçoDosItens.Add("Botas", 238.43);
        }
        public double GetItemPrice(string NomeDoItem)
        {
            if (PreçoDosItens.ContainsKey(NomeDoItem))
            {
                return PreçoDosItens[NomeDoItem];
            }
            else
            {
                Console.WriteLine("O item '{NomeDoItem}' nao foi encontrado no estoque");
                return 0.0;
            }

        }
        public double Espada = 1000.0;
        public double Elixir = 50.34;
        public double Arco = 200.34;
        public double Botas = 238.43;

        public override string ToString()
        {
            return "~Espada Draconica do guardiao mestre^_^  \n"
                + "R$" + Espada.ToString("F2")
                + "\n*************************************************************"
                + "\n~Elixir da vida do alquimista cheio de marra^0^ \n"
                + "R$" + Elixir.ToString("F2") 
                + "\n************************************************************"
                + "\n~Arco Recurvo do guerreiro perdido X_X  \n"
                + "R$" + Arco.ToString("F2")
                + "\n************************************************************"
                + "\n~Botas magicas do feiticeiro encurralado> <  \n"
                + "R$" + Botas.ToString("F2")
                + "\n*************************************************************"
                ;
        }

    }
}
