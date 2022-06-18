// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// 56789 -> 35

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfDigits(int number)
{
    int digits = 0;

    while (number > 0)
    {
        digits = digits + number % 10;

        number = number / 10;
    }
    return digits;
}

int number = Prompt("Введите чило => ");
Console.WriteLine($"Сумма цифр числа {number} равна {SumOfDigits(number)}");
