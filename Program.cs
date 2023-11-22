using babou_no_beck_ta_expulso_da_sessão_nerdola;
using System;
using System.Globalization;

public class BeckTorto
{
    static void Main(string[] args)
    {
        
        Cardapio Gzinho = new Cardapio(); //chamada do objeto
        Carrinho Dmax = new Carrinho();
        string respo1;

        Console.WriteLine("`(*>_<*)′ Olá, seja muito bem vindo(a) a BIQUEIRA ONLINE");
        Console.WriteLine();
        Console.WriteLine("Gostaria de dar uma olhada no nosso cardápio?? (responder com s/n)");
        char resp = char.Parse(Console.ReadLine());   
            
        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine(Gzinho);
            Console.WriteLine("Por favor escolha alguma de nossas opçoes acima > <");
            Console.WriteLine();
            string resposta = Console.ReadLine();
                switch (resposta) //opçoes de compra
                {
                    case "Cocaina":
                        Dmax.Cocaina();
                        break;
                    case "Prensado":
                        Dmax.Pren();
                        break;
                    case "Haxixe":
                        Dmax.Hax();
                        break;
                    case "Pedra":
                        Dmax.Pedra();
                        break;
                    default:
                        Console.WriteLine("nao sabia que noia era tao burro assim . . . ");
                        break;
                }

                Console.WriteLine("TMJ NOIA, aqui esta o seu carrinho de compras: \n");
                Console.WriteLine(Dmax);
                Console.WriteLine();
                Console.WriteLine("O senhor deseja mais alguma coisa?? (responder com SIM ou NAO) ");
                respo1 = Console.ReadLine();
             
            if (respo1 == "SIM")
            {
                Console.WriteLine("claro Gzinho aqui esta o cardapio pra voce olhar novamente: ");
                Console.WriteLine();
                Console.WriteLine(Gzinho);
                Console.Write("Faça seu pedido: ");
                string rsp = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("aqui esta o seu carrinho: ");
                Console.WriteLine(Dmax);
                Console.WriteLine("Vou perguntar novamente. . .O senhor deseja mais alguma coisa?? (responder com SIM ou NAO) ");
                respo1 = Console.ReadLine();
            }  
            else
            {
                Console.WriteLine("obrigado pela preferencia, volte sempre :)");
            }
   
        }
        else if (resp == 'n' || resp == 'N')
        {
            Console.WriteLine("Sem problemas!!");
            Console.WriteLine();
            Console.WriteLine("tambem temos uma loja de celular e aparelhos furtados, quer dar uma olhada? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine(". . . infelizemnte um de nossos principais furtadores foi pego pela policia, estaremos retornando em breve T_T");
            }
            else
            {
                Console.WriteLine(". . . tudo bem amigo, volte sempre. . . ");
            }
        }
        else
        {
            Console.WriteLine("ERRO!! NAO ENTENDI FAZ DNV");
        }
    }
}
