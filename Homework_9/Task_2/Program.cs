// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int PrintSumNatural(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return PrintSumNatural(M, N-1)+N;
}

int M = Prompt("write M => ");
int N = Prompt("write N => ");

int sum = PrintSumNatural(M, N);
System.Console.WriteLine($"Cумма натуральных элементов в промежутке от {M} до {N} равна => {sum}");
