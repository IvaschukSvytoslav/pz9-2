using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1, b = 2, c = 3; // Задаємо коефіцієнти
        Func<double, double> quadraticFunc = x => a * x * x + b * x + c;

        for (int x = 0; x <= 10; x++)
        {
            double y = quadraticFunc(x);
            Console.WriteLine($"y({x}) = {y}");
        }
    }
}

