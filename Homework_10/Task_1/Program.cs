// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого
// числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

void MonotonousSequence(int number)
{
    for (int i = 1; i < number; i++)
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.Write($"{i} ");
        }
    }
}

int number = Prompt("До какй цифры необходимо вывести последоватьеность на экран? ");
MonotonousSequence(number);