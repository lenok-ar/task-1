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
        Console.Write("Введите число содержащее от трех до шести цифр (включительно): ");

        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber < 100 & inputNumber > 1000000)
        {
            Console.Write("Число содержит меньше трех цифр или больше шести");
        }

        if (inputNumber > 100 & inputNumber < 999)
        {
            int secondDigit = (inputNumber / 10) % 10;
            int CombineTheNumber = (inputNumber / 100) * 10 + (inputNumber % 10);
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (inputNumber > 1000 & inputNumber < 9999)
        {
            int secondDigit = (inputNumber / 100) % 10; // находим вторую цифру в числе
            int CombineTheNumber = (inputNumber / 1000) * 100 + (inputNumber % 100); // объединяем все оставшиеся числа в одно, удаляем вторую цифру
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (inputNumber > 10000 & inputNumber < 99999)
        {
            int secondDigit = (inputNumber / 1000) % 10;
            int CombineTheNumber = (inputNumber / 10000) * 1000 + (inputNumber % 1000);
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (inputNumber > 100000 & inputNumber < 999999)
        {
            int secondDigit = (inputNumber / 10000) % 10;
            int CombineTheNumber = (inputNumber / 100000) * 10000 + (inputNumber % 10000);
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }
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

