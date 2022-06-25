// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

double[] InitArray(int len, double min, double max)
{
    double[] arrA = new double[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().NextDouble() * (max - min) + min;
    }
    return arrA;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]:f}; ");
    }
    Console.WriteLine($"{array[array.Length - 1]:f}]");
}

double DifferenceMaxMin(double[] array)
{
    double resoult = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    resoult = max - min;
    return resoult;
}

int len = Prompt("Введите длину массива => ");

double[] myArray = InitArray(len, 1, 10);
PrintArray(myArray);
Console.WriteLine($"Разницу между максимальным и минимальным элементом массива => {DifferenceMaxMin(myArray):f}");