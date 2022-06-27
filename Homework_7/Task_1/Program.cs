// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int row, int column, int min, int max)
{
    double[,] array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}" + "\t");
        }
        Console.WriteLine();
    }
}

int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");
int min = -10;
int max = 10;

double[,] array = GenerateArray(row, column, min, max);
PrintArray(array);