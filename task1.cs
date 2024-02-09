using System;

class Program
{
    static bool IsDivisibleBy7And23(int number)
    {
        if (number % 7 == 0 && number % 23 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int inputNumber = int.Parse(Console.ReadLine());

        if (IsDivisibleBy7And23(inputNumber))
        {
            Console.WriteLine($"Число {inputNumber} кратно 7 и 23");
        }
        else
        {
            Console.WriteLine($"Число {inputNumber} не кратно одновременно 7 и 23");
        }
    }
}
