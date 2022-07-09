// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

void PrintNatural(int M, int N)
{
    if (M > N)
    {
        return;
    }
    if (N % 2 == 1)
    {
        N--;
    }
    PrintNatural(M, N-2);
    System.Console.Write($"{N};");
}

PrintNatural(Prompt("Введите M => "), Prompt("Введите N => "));