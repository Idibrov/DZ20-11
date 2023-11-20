using System;

public class Sqrt
{
    public static void Main()
    {
        if (TryGetUserInput(out double target))
        {
            double result = CalculateSquareRoot(target);

            Console.WriteLine($"Квадратный корень: {result}");
            Console.WriteLine($"Квадрат квадратного корня: {result * result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа.");
        }
    }

    public static bool TryGetUserInput(out double input)
    {
        Console.Write("Введите число: ");
        return double.TryParse(Console.ReadLine(), out input);
    }

    public static double CalculateSquareRoot(double target)
    {
        double x = 1;
        double oldx;

        do
        {
            oldx = x;
            x = (x + target / x) / 2;
        }
        while (oldx != x);

        return x;
    }
}
