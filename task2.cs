using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвёртой координатной четверти");
        }
        else
        {
            Console.WriteLine("Точка лежит на одной из осей");
        }
    }
}
