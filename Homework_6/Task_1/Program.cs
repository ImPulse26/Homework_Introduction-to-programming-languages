// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int[] IntNumbers(int quantity)
{
    int[] QuantityNumbers = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        QuantityNumbers[i] = Prompt($"Введите {i + 1} из {quantity} чисел => ");
    }
    return QuantityNumbers;
}

int PositiveNumber(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0) count++;
    }
    return count;
}

int quantity = Prompt($"Сколько чисел вывести? => ");
int[] myNumbers = IntNumbers(quantity);
int countPositiveNumber = PositiveNumber(myNumbers);
Console.WriteLine($"Положительных чисел => {countPositiveNumber}");


