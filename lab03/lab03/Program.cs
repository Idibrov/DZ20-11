using System;

class ShootingGame
{
    static void Main()
    {
        Random random = new Random();
        const int targetRadius = 5;
        const int innerCircleRadius = 3;

        int totalPoints = 0;

        Console.WriteLine("Тир");

        int numberOfShots = 5;
        int[,] shotCoordinates = new int[numberOfShots, 2];

        for (int i = 0; i < numberOfShots; i++)
        {
            int targetX = random.Next(-10, 11);
            int targetY = random.Next(-10, 11);

            Console.WriteLine($"\n// Мишень в ({targetX}, {targetY})");

            Console.Write("Введите координату x для выстрела: ");
            int shotX = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y для выстрела: ");
            int shotY = int.Parse(Console.ReadLine());

            shotCoordinates[i, 0] = shotX;
            shotCoordinates[i, 1] = shotY;

            double distanceToTarget = Math.Sqrt(Math.Pow(shotX - targetX, 2) + Math.Pow(shotY - targetY, 2));

            int points = 0;

            if (distanceToTarget > targetRadius)
            {
                points = 0; // Если выстрел за границами круга
            }
            else if (distanceToTarget <= innerCircleRadius)
            {
                points = 10; // Если выстрел внутри внутреннего круга
            }
            else
            {
                points = 5; // Если выстрел вне внутреннего круга, но внутри внешнего
            }

            totalPoints += points;

            Console.WriteLine($"Выстрел на ({shotX}, {shotY}) - {points} баллов");
            Console.WriteLine($"Итого баллов: {totalPoints}");

            if (i == 4) 
            {
                break;
            }

            Console.Write("\nХотите ли вы продолжить стрельбу? (да/нет): ");
            string continueShooting = Console.ReadLine().ToLower();

            if (continueShooting != "да")
            {
                break;
            }
        }

        Console.WriteLine($"Игра завершена. Итого баллов: {totalPoints}");

        Console.WriteLine("\nКоординаты выстрелов:");
        for (int i = 0; i < numberOfShots; i++)
        {
            Console.WriteLine($"Shot {i + 1}: ({shotCoordinates[i, 0]}, {shotCoordinates[i, 1]})");
        }
    }
}
