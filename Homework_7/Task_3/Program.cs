// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMean(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum = columnSum + array[i, j];
        }
        newArray[j] = columnSum / array.GetLength(0);
    }
    return newArray;
}

void PrintArithmeticMean(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    foreach (double element in array)
    {
        Console.Write($"{element:f2}" + "\t");
    }
    Console.WriteLine();
}

int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");
int min = -10;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
PrintArithmeticMean(ArithmeticMean(array));