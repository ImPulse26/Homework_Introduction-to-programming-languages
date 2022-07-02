// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplicationOfTwoArray(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                newArray[i, j] = newArray[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return newArray;
}

void MultiplicationIsPossible(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] newArray = MultiplicationOfTwoArray(array1, array2);
        PrintArray(newArray);
    }
    else
    {
        System.Console.WriteLine($"Найти произведение двух матриц невозможно, т.к. {array1.GetLength(1)}(число столбцов в первом массиве) не равно {array2.GetLength(0)}(число строк во втором массиве).");
    }
}

int row1 = 3;
int column1 = 4;
int row2 = 4;
int column2 = 5;
int min = 0;
int max = 10;

int[,] array1 = GenerateArray(row1, column1, min, max);
int[,] array2 = GenerateArray(row2, column2, min, max);
PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();
MultiplicationIsPossible(array1, array2);