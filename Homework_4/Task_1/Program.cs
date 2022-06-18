// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Exponentiationt (int number1, int number2)
{
    int result = 1;
    for (int i=1; i <= number2; i++)
    {
        result = result*number1;
    }
    return result;
}

int number1 = Prompt("Введите число => ");
int number2 = Prompt("Введите степень => ");
Console.WriteLine($"Число {number1} возведенное в степень {number2} равно => {Exponentiationt(number1, number2)}");