// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите день недели => ");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number >= 1 && number <= 5)
{
    Console.WriteLine($"День недели {number}, рабочий день.");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine($"День недели {number}, выходной.");
}
else
{
    Console.WriteLine($"Дня недели {number}, нет.");
}
