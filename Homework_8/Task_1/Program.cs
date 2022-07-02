// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ArrangeTheElementsInDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, max] < array[i, k])
                {
                    max = k;
                }
            }
            int temp = array[i, max];
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");
int min = -10;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();
ArrangeTheElementsInDescendingOrder(array);
PrintArray(array);
