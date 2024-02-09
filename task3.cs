using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число из отрезка [10, 99]: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 0;

        // Проверяем каждую цифру числа
        while (number > 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа

            if (digit > maxDigit)
            {
                maxDigit = digit;
            }

            number = number / 10; // Убираем последнюю цифру числа
        }

        Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
    }
}
