// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfDigits(int number){
    int counter = number.Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        numberN = number / 10;
    }
    return result;
}

int number = Prompt("Введите чило => ");
int sumOfDigits = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {SumOfDigits(number)}");
