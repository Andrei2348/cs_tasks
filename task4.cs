using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число N: ");
        int number = int.Parse(Console.ReadLine());

        string digits = "";

        // Разделяем число на цифры и добавляем их в строку
        while (number > 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа

            if (digits == "")
            {
                digits += digit.ToString();
            }
            else
            {
                digits = digit.ToString() + ", " + digits;
            }

            number = number / 10; // Убираем последнюю цифру числа
        }

        Console.WriteLine($"Цифры числа через запятую: {digits}");
    }
}
