// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumOfRow(int[,] array, int row)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow = sumRow + array[row, j];
    }
    return sumRow;
}

int [] MinimumSumRow (int [,] array)
{
    int[] numberAndSumRow = new int[2];
    numberAndSumRow[1] = SumOfRow(array,numberAndSumRow[0]);
    for (int i = 0; i < array.GetLength(0);i++)
    {
        if (numberAndSumRow[1] > SumOfRow(array,i))
        {
            numberAndSumRow[0] = i;
            numberAndSumRow[1] = SumOfRow(array, numberAndSumRow[0]);
        }
    }
    return numberAndSumRow;
}

int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");
int min = 0;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine($"Минимальная сумма элементов = {MinimumSumRow(array)[1]}, в строке => {MinimumSumRow(array)[0]+1}.");
