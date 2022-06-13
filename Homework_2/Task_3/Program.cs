// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число => ");
string srt = Console.ReadLine();
int number = int.Parse(srt);

int result1 = number % 10;
int result2 = number % 100 / 10;
int result3 = number % 1000 / 100;

if (number < 99) Console.WriteLine($"Третьей цифры нет");
if (number > 99 && number < 1000) Console.WriteLine($"Третья цифра {result1}");
if (number > 999 && number < 10000) Console.WriteLine($"Третья цифра {result2}");
if (number > 9999 && number < 100000) Console.WriteLine($"Третья цифра {result3}");
