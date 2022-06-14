// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите пятизначное число => ");

int[] array = new int[5];
array[0] = number / 10000;
array[1] = number % 10000 / 1000;
array[2] = number % 1000 / 100;
array[3] = number % 100 / 10;
array[4] = number % 10;

if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine($"Введеное число ЯВЛЯЕТСЯ палиндромом");
else Console.WriteLine($"Введеное число НЕ является палиндромом");