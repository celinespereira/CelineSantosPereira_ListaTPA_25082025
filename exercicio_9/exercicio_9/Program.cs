using System;

class Program
{
    static void Main()
    {
        int A2 = 0, A3 = 0, A4 = 0, A5 = 0;
        string R;

        do
        {
            Console.Write("Digite um número: ");
            int A1 = int.Parse(Console.ReadLine());

            if (A1 % 2 == 0)
                A2++;
            else
                A3++;

            if (A1 > 0)
                A4++;
            else if (A1 < 0)
                A5++;

            Console.Write("Deseja encerrar o programa? (Digite S para SIM ou Digite N para NÃO): ");
            R = Console.ReadLine().ToUpper();

        } while (R != "S");

        Console.WriteLine($"Quantidade de números Pares: {A2}");
        Console.WriteLine($"Quantidade de números Ímpares: {A3}");
        Console.WriteLine($"Quantidade de números Positivos: {A4}");
        Console.WriteLine($"Quantidade de números Negativos: {A5}");
    }
}
