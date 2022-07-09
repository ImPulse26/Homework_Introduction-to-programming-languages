// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

int M = Prompt("Введите полочительное число(M) => ");
int N = Prompt("Введите полочительное число(N) => ");

int functioAckerman = AckermanFunction(M, N);
System.Console.WriteLine($"При m = {M} и n = {N}, функция Аккермана равна => {functioAckerman}");