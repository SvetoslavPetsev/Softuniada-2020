using System;

namespace _02._New_Building
{
    class Program
    {
        static void PrintFirstRow(int points)
        {
            Console.Write("#");
            for (int i = 1; i <= points - 1; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int points = size;
            int row = size + size / 2;

            PrintFirstRow(points);
            row--;
            int counterDots = 0;
            for (int i = 1; i <= row; i++)
            {
                counterDots++;
                for (int j = counterDots; j <= points; j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                points++;
            }
        }
    }
}
