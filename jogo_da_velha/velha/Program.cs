using System;

class Program
{
    static void Main()
    {
        char J = 'X', C = 'O';
        

        Console.Write("Digite seu nome: ");
        string A1 = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Escolha entre (X) ou (O):");
            Console.WriteLine("1 - X");
            Console.WriteLine("2 - O");
            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 1:
                    J = 'X';
                    C = 'O';
                    break;

                case 2:
                    J = 'O';
                    C = 'X';
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.\n");
                    continue; 
            }
            break; 
        }


        Console.WriteLine($"\n Você vai jogar com '{J}' e o computador com '{C}'.");

        int pontj= 0, pontpc = 0, empt = 0;
        string cont = "s";

        Random sort = new Random();

        while (cont == "s")
        {
            char[,] jg = new char[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    jg[i, j] = ' ';

            bool F = false;
            char vencedor = ' ';

            while (!F)
            {
                Console.Clear();
                Console.WriteLine("   0   1   2");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" " + jg[i, j] + " ");
                        if (j < 2) Console.Write("|");
                    }
                    Console.WriteLine();
                    if (i < 2) Console.WriteLine("  ---+---+---");
                }

                Console.Write($"\nDigite linha e coluna (ex: 1 2): ");
                string[] pos = Console.ReadLine().Split(' ');
                int l = int.Parse(pos[0]);
                int c = int.Parse(pos[1]);

                if (jg[l, c] == ' ')
                {
                    jg[l, c] = J;
                }
                else
                {
                    Console.WriteLine("Esse lugar já está ocupado, aperte enter pra voltar");
                    Console.ReadLine();
                    continue;
                }

                if (Venceu(jg, J))
                {
                    vencedor = J;
                    pontj++;
                    F = true;
                }

                if (!F)
                {
                    int li, co;
                    do
                    {
                        li = sort.Next(0, 3);
                        co = sort.Next(0, 3);
                    } while (jg[li, co] != ' ');

                    jg[li, co] = C;

                    if (Venceu(jg, C))
                    {
                        vencedor = C;
                        pontpc++;
                        F = true;
                    }
                }

                if (!F)
                {
                    bool cheio = true;
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            if (jg[i, j] == ' ')
                                cheio = false;

                    if (cheio)
                    {
                        empt++;
                        F = true;
                    }
                }
            }

            Console.Clear();
            if (vencedor == J) Console.WriteLine($"Você ganhou");
            else if (vencedor == C) Console.WriteLine("PC ganhou");
            else Console.WriteLine("Empate");

            Console.WriteLine($"{A1}: {pontj} vitórias");
            Console.WriteLine($"Computador: {pontpc} vitórias");
            Console.WriteLine($"Empates: {empt}");

            Console.Write("\nQuer jogar de novo? (Digite s para SIM, ou n para NÃO): ");
            cont = Console.ReadLine().ToLower();
        }
    }

    static bool Venceu(char[,] t, char s)
    {
        for (int i = 0; i < 3; i++)
        {
            if (t[i, 0] == s && t[i, 1] == s && t[i, 2] == s) return true;
            if (t[0, i] == s && t[1, i] == s && t[2, i] == s) return true;
        }
        if (t[0, 0] == s && t[1, 1] == s && t[2, 2] == s) return true;
        if (t[0, 2] == s && t[1, 1] == s && t[2, 0] == s) return true;

        return false;
    }
}
