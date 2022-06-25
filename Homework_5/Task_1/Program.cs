// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int evenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            count++;
        }
    return count;
}

int len = Prompt("Введите длину массива => ");

int[] myArray = InitArray(len, 100, 999);
PrintArray(myArray);
Console.WriteLine($"Четных чисел в массиве => {evenNumbers(myArray)}");