using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babou_no_beck_ta_expulso_da_sessão_nerdola
{
    internal class Carrinho
    {
        private Dictionary <string,int> itens = new Dictionary <string,int> ();//dictionary is a generic collection which we used to store key/value pairs.
        Cardapio Gzinho = new Cardapio ();

        public void Add(string NomedoItem, int Quantidade)//Method to add an specified quantity to the cart.
        {
            if (itens.ContainsKey(NomedoItem))
            {
                itens[NomedoItem] += Quantidade;
            }
            else
            {
                itens.Add(NomedoItem, Quantidade);
            }
        }

        public double Calcular()//calculate and return the total price of items in the cart.
        {
            double total = 0;
            foreach(var item in itens)
            {
                double PreçoItem = Gzinho.GetItemPrice(item.Key);
                total += PreçoItem * item.Value;
            }
            return total;
        }

        public override string ToString()//display cart content
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Itens no carrinho: ");
            
            foreach(var item in itens)
            {
                sb.AppendLine(item.Key + "\n" + item.Value + " unidades\n");
            }
            
            sb.AppendLine("Preço final: " + Calcular());
            return sb.ToString();

        }
        public double Espada = 1000.0;
        public double Elixir = 50.34;
        public double Arco = 200.34;
        public double Botas = 238.43;
        public double Saldo;

        public void EspadaDroconica()//by: deivid
        {
            Saldo += Espada;
        }
        public void ElixirDaVida()
        {
            Saldo += Elixir;
        }

        public void ArcoRecurvo()
        {
            Saldo += Arco;
        }

        public void BotasMagicas()
        {
            Saldo += Botas;
        }

    }
}
