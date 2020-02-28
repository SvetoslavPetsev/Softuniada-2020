using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01._Dream_car
{
    class Program
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double monthCosts = double.Parse(Console.ReadLine());
            double monthSalaryGrow = double.Parse(Console.ReadLine());
            double carPrice = double.Parse(Console.ReadLine());
            BigInteger monthSafe = long.Parse(Console.ReadLine());

            double safeMoney = income;
            double allCosts = (double)monthSafe * monthCosts;
            for (int i = 1; i < monthSafe; i++)
            {
                double currIncome = income + monthSalaryGrow;
                safeMoney += currIncome;
                income = currIncome;
            }
            safeMoney -= allCosts;
            if (safeMoney >= carPrice)
            {
                Console.WriteLine("Have a nice ride!");
            }
            else
            {
                Console.WriteLine("Work harder!");
            }
        }
    }
}
