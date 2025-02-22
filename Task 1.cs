using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void FirstProgram()
    {
        Console.Write("Введите число которое будут возводить в степень: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение степени: ");
        int power = Convert.ToInt32(Console.ReadLine());
        int numberRaisedToAPower = number; // число возведенное в степень

        for (int i = 1; i < power; i++)
        {
            numberRaisedToAPower = numberRaisedToAPower * number;
        }
        Console.WriteLine($"Результат: {numberRaisedToAPower}");
    }

    static void SecondProgram()
    {
        Console.Write("Введите число, содержащее более двух цифр: ");
        string input = Console.ReadLine();

        if (input.Length < 3)
        {
            Console.WriteLine("Число должно содержать более двух цифр.");
            return;
        }

        int secondDigit = (input[1] - '0'); // Вторая цифра (как символ)
        string modifiedNumber = input[0].ToString(); // Первая цифра

        // Пропуск второй цифры
        for (int i = 2; i < input.Length; i++)
        {
            modifiedNumber += input[i]; // Собираем новое число без второй цифры
        }

        // Добавляем вторую цифру в конец
        modifiedNumber += secondDigit;

        Console.WriteLine($"Результат: {modifiedNumber}");
    }

    static void Main()
    {
        string choice;

        while (true)
        {
            Console.Write("Выберите задание (для работы первого задания введите 1, для работы второго задания - 2): ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FirstProgram();
                    break;
                case "2":
                    SecondProgram();
                    break;
            }
        }
    }
}
