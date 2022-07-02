// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

string FindTheNumber(int[,] array, int rowPosition, int columnPosition)
{
    string position = "";
    if (rowPosition < 1 || columnPosition < 1 || rowPosition > array.GetLength(0) || rowPosition > array.GetLength(1))
    {
        position = "Такой позиции в созданном массиве нет";
    }
    else
    {

        position = $"В позиции [{rowPosition}, {columnPosition}] находится число => {array[rowPosition - 1, columnPosition - 1]}";
    }
    return position;
}

int row = Prompt("Количество строк => ");
int column = Prompt("Количество столбцов => ");
int min = -10;
int max = 10;
int rowPosition = Prompt("Укажите строку => ");
int columnPosition = Prompt("Укажите столбец => ");

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine(FindTheNumber(array, rowPosition, columnPosition));