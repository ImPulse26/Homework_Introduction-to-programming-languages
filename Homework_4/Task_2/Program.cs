// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int factorial (int N)// 5
{
    int result = 1;
    for (int i=2; i <= N; i++) //2 до 5||i=2||i=3||i=4||i=5
    {
        result = result*i;// 1*2=2||2*3=6||6*4=24||24*5=120
    }
    return result;
}

int N = prompt("Введите чило: ");
Console.WriteLine ($"Произведение чисел от 1 до {N} равно {factorial(N)}");
