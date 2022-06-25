// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int[] InitArray(int len, int min, int max)
{
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().Next(min, max + 1);
    }
    return arrA;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}

int SumNumbersOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 1) {
            sum = sum + array[i];
        }
    return sum;
}

int len = Prompt("Введите длину массива => ");

int[] myArray = InitArray(len, -10, 10);
PrintArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях => {SumNumbersOddPositions(myArray)}");