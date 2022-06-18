// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами(до 1000) и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

int prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int size = prompt("Введите число элементов массива: ");
int[] array = new int[size];
int k = 0;

void RandomArray01(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        k = new Random().Next(0, 2);
        array[i] = k;
    }
}

int[] RandomArrayF(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        k = new Random().Next(0, 2);
        array[i] = k;
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
//PrintArray(array);
RandomArray01(array);
PrintArray(array);
PrintArray(RandomArrayF(array));
