using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число b: ");
        int b = int.Parse(Console.ReadLine());

        int nod = EuclideanAlg(a, b);

        Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} равен {nod}");
    }

    static int EuclideanAlg(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
