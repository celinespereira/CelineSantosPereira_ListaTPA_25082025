using System;

class Program
{
    static void Main()
    {
        string R;

        do
        {
            Console.Write("Digite o código: ");
            string A1 = Console.ReadLine();

            Console.Write("Digite o número de horas: ");
            int A2 = int.Parse(Console.ReadLine());

            int E = 0;
            int B = 0;

            if (A2 > 50)
            {
                E = (A2 - 50) * 20;
                B = 50 * 10;
            }
            else
            {
                B = A2 * 10;
            }

            int T = B + E;

            Console.WriteLine($"Salário total: R$ {T}");
            Console.WriteLine($"Salário excedente: R$ {E}");

            Console.Write("Deseja encerrar o programa? (Digite S para SIM ou N para NÃO): ");
            R = Console.ReadLine().ToUpper();

        } while (R!= "S");
    }
}
