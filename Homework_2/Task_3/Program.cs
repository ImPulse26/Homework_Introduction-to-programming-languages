// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число => ");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number < 100) Console.WriteLine($"Третьей цифры нет");
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра числа => {number}");
}