using babou_no_beck_ta_expulso_da_sessão_nerdola;
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

public class BeckTorto
{
    static void Main(string[] args)
    {
        int N;
        Cardapio Gzinho = new Cardapio(); //chamada do objeto
        Carrinho Dmax = new Carrinho();
        string respo1, resposta;

        Console.WriteLine("`(*>_<*)′ Olá, seja muito bem vindo(a) a TABERNA SKYRIM DE REALENGO");
        Console.WriteLine("Sente-se, gostaria de olhar um pouco de nosso arsenal de itens?? (responder com s/n)");
        char resp = char.Parse(Console.ReadLine());   
            
        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine(Gzinho);
            Console.WriteLine("Estas são nossas opçoes no momento");
            resposta = Console.ReadLine();
                switch (resposta) //opçoes de compra
                {
                    case "Espada":
                        Dmax.EspadaDroconica();
                        break;
                    case "Elixir":
                        Dmax.ElixirDaVida();
                        break;
                    case "Arco":
                        Dmax.ArcoRecurvo();
                        break;
                    case "Botas":
                        Dmax.BotasMagicas();
                        break;
                    default:
                        Console.WriteLine("nao sabia que noia era tao burro assim . . . ");
                        break;
                }
            Console.WriteLine("Escolha a quantidade: ");
            N = int.Parse(Console.ReadLine());

            Dmax.Add(resposta, N);
            Console.WriteLine("TMJ NOIA, aqui esta o seu carrinho de compras: \n");
            Console.WriteLine(Dmax);
        }
        else if (resp == 'n' || resp == 'N')//feedback.
        {
            Console.WriteLine("Sem problemas!! deixe seu feedback do que deveriamos adcionar a nossa loja: \n");
            Console.WriteLine("Quantos produto vc vai sujerir? \n");
            N = int.Parse(Console.ReadLine());
            
            string[] Produto = new string[N];
            Console.WriteLine("Escreva o nome deles abaixo: ");
            
            for (int i = 0; i < N; i++)
            {
                Produto[i] = Console.ReadLine();
            }
            Console.WriteLine("\nOtimas escolhas, obrigado pela ajuda!!");
        }
        else
        {
            Console.WriteLine("ERRO!! NAO ENTENDI FAZ DNV");
        }
    }
}
