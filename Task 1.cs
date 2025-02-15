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

        int firstNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber < 100 & firstNumber > 1000000)
        {
            Console.Write("Число содержит меньше трех цифр или больше шести");
        }

        if (firstNumber > 100 & firstNumber < 999)
        {
            int secondDigit = (firstNumber / 10) % 10;
            int CombineTheNumber = (firstNumber / 100) * 10 + (firstNumber % 10);
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (firstNumber > 1000 & firstNumber < 9999)
        {
            int secondDigit = (firstNumber / 100) % 10; // находим вторую цифру в числе
            int CombineTheNumber = (firstNumber / 1000) * 100 + (firstNumber % 100); // объединяем все оставшиеся числа в одно, удаляем вторую цифру
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (firstNumber > 10000 & firstNumber < 99999)
        {
            int secondDigit = (firstNumber / 1000) % 10;
            int CombineTheNumber = (firstNumber / 10000) * 1000 + (firstNumber % 1000);
            int finalNumber = CombineTheNumber * 10 + secondDigit;

            Console.WriteLine($"Результат: {finalNumber}");
        }

        if (firstNumber > 100000 & firstNumber < 999999)
        {
            int secondDigit = (firstNumber / 10000) % 10;
            int CombineTheNumber = (firstNumber / 100000) * 10000 + (firstNumber % 10000);
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
                    sSecondProgram();
                    break;
            }
        }
    }
}
