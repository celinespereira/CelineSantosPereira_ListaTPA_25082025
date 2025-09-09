using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int pontuacaou1 = 0, pontuacaou12 = 0, pontuacaou2 = 0, pontuacaopc = 0, pontuacaoempt = 0, pontuacaoempt1 = 0;
        string cont = "s", A5;

        Random r = new Random();

        List<string> escolhasUser1 = new List<string>();
        List<string> escolhasUser2 = new List<string>();
        List<string> escolhasPC = new List<string>();

        Console.Write("Digite seu nome user1: ");
        string A1 = Console.ReadLine();

        while (cont == "s")
        {
            Console.WriteLine("Você quer jogar contra o PC ou contra outro player? ");
            Console.WriteLine("1 - PC");
            Console.WriteLine("2 - Player");
            int esc = int.Parse(Console.ReadLine());

            if (1 == esc)
            {
                Console.WriteLine("Você jogará contra o PC, digite ENTER para prosseguir");
                Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("User1 escolha entre PEDRA, PAPEL ou TESOURA: \n");
                    Console.WriteLine("1 - Pedra");
                    Console.WriteLine("2 - Papel");
                    Console.WriteLine("3 - Tesoura");
                    int respu1 = int.Parse(Console.ReadLine());

                    int ale = r.Next(1, 4);

                    if (respu1 == 1) escolhasUser1.Add("Pedra");
                    if (respu1 == 2) escolhasUser1.Add("Papel");
                    if (respu1 == 3) escolhasUser1.Add("Tesoura");

                    if (ale == 1) escolhasPC.Add("Pedra");
                    if (ale == 2) escolhasPC.Add("Papel");
                    if (ale == 3) escolhasPC.Add("Tesoura");

                    if (respu1 == ale)
                    {
                        Console.WriteLine("Empate");
                        pontuacaoempt += 1;
                    }

                    if (respu1 == 1 && ale == 3 || respu1 == 3 && ale == 2 || respu1 == 2 && ale == 1)
                    {
                        Console.WriteLine("user1 ganhou");
                        pontuacaou1 += 1;
                    }

                    if (ale == 1 && respu1 == 3 || ale == 3 && respu1 == 2 || ale == 2 && respu1 == 1)
                    {
                        Console.WriteLine("PC ganhou");
                        pontuacaopc += 1;
                    }

                    Console.WriteLine(" ---------- Ranking ---------- ");
                    Console.WriteLine("User1: " + A1);
                    Console.WriteLine("Vitórias do User1: " + pontuacaou1);
                    Console.WriteLine("Derrotas (PC venceu): " + pontuacaopc);
                    Console.WriteLine("Empates: " + pontuacaoempt);
                    Console.WriteLine("Opções User1: " + string.Join(", ", escolhasUser1));
                    Console.WriteLine("Opções PC: " + string.Join(", ", escolhasPC));

                    Console.Write("\nQuer jogar de novo? (Digite 's' para SIM, ou 'n' para NÃO): ");
                    cont = Console.ReadLine().ToLower();

                    break;
                }
            }
            else
            {
                Console.WriteLine("Você jogará contra outro player, digite ENTER para prosseguir");
                Console.ReadLine();

                Console.Write("Digite seu nome user2: ");
                string A2 = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("User1 escolha entre PEDRA, PAPEL ou TESOURA: \n");
                    Console.WriteLine("1 - Pedra");
                    Console.WriteLine("2 - Papel");
                    Console.WriteLine("3 - Tesoura");
                    int respu1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("USER1 NÃO OLHE PARA A TELA, E USER2 NÃO OLHE PARA CIMA \n");
                    Console.ReadLine();

                    Console.WriteLine("User2 escolha entre PEDRA, PAPEL ou TESOURA: \n");
                    Console.WriteLine("1 - Pedra");
                    Console.WriteLine("2 - Papel");
                    Console.WriteLine("3 - Tesoura");
                    int respu2 = int.Parse(Console.ReadLine());

                    if (respu1 == 1) escolhasUser1.Add("Pedra");
                    if (respu1 == 2) escolhasUser1.Add("Papel");
                    if (respu1 == 3) escolhasUser1.Add("Tesoura");

                    if (respu2 == 1) escolhasUser2.Add("Pedra");
                    if (respu2 == 2) escolhasUser2.Add("Papel");
                    if (respu2 == 3) escolhasUser2.Add("Tesoura");

                    if (respu1 == respu2)
                    {
                        Console.WriteLine("Empate");
                        pontuacaoempt1 += 1;
                    }

                    if (respu1 == 1 && respu2 == 3 || respu1 == 3 && respu2 == 2 || respu1 == 2 && respu2 == 1)
                    {
                        Console.WriteLine("user1 ganhou");
                        pontuacaou12 += 1;
                    }

                    if (respu2 == 1 && respu1 == 3 || respu2 == 3 && respu1 == 2 || respu2 == 2 && respu1 == 1)
                    {
                        Console.WriteLine("user2 ganhou");
                        pontuacaou2 += 1;
                    }

                    Console.WriteLine(" ---------- Ranking ---------- ");
                    Console.WriteLine("User1: " + A1);
                    Console.WriteLine("User2: " + A2);
                    Console.WriteLine("Vitórias do User1: " + pontuacaou12);
                    Console.WriteLine("Vitórias do User2: " + pontuacaou2);
                    Console.WriteLine("Empates: " + pontuacaoempt1);
                    Console.WriteLine("Opções User1: " + string.Join(", ", escolhasUser1));
                    Console.WriteLine("Opções User2: " + string.Join(", ", escolhasUser2));

                    Console.Write("\nQuer jogar de novo? (Digite s para SIM, ou n para NÃO): ");
                    cont = Console.ReadLine().ToLower();

                    break;
                }
            }
        }
        Console.ReadKey();
    }
}
