using babou_no_beck_ta_expulso_da_sessão_nerdola;
using System;
using System.Globalization;

public class BeckTorto
{
    static void Main(string[] args)
    {
        
        Cardapio Gzinho = new Cardapio(0); //chamada do objeto
        

        Console.WriteLine("`(*>_<*)′ Olá, seja muito bem vindo(a) a biquera online, aqui fazemos a magia acontecer ");
        Console.WriteLine();
        Console.WriteLine("Gostaria de dar uma olhada no nosso cardápio?? (resoponder com s/n)");
        char resp = char.Parse(Console.ReadLine());   
            
        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine(Gzinho);
            Console.WriteLine("Por favor escolha alguma de nossas opçoes acima > <");
            Console.WriteLine();
            Console.WriteLine("Digite (sair) para sair");
            string resposta = Console.ReadLine();
            while (resposta != "sair")
            {
                switch (resposta) //opçoes de compra
                {
                    case "Cocaina":
                        Gzinho.Cocaina();
                        break;
                    case "Prensado":
                        Gzinho.Pren();
                        break;
                    case "Haxixe":
                        Gzinho.Hax();
                        break;
                    case "Pedra":
                         Gzinho.Pedra();
                        break;
                    default:
                        Console.WriteLine("nao sabia que noia era tao burro assim . . . ");
                        break;
                }

                Console.WriteLine("MUITO OBRIGADO(a) PELA PREFERENCIA, aqui esta o seu saldo de compras: \n");
                Console.WriteLine(Gzinho);
                Console.WriteLine();
                Console.WriteLine("O senhor deseja mais alguma coisa?? (responder com SIM ou NAO ou digite sair) ");
                string respo1 = Console.ReadLine();
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
