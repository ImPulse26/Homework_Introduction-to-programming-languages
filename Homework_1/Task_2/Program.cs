// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число => ");
string numberSrt1 = Console.ReadLine();
int a = int.Parse(numberSrt1);
Console.Write("Введите второе число => ");
string numberSrt2 = Console.ReadLine();
int b = int.Parse(numberSrt2);
Console.Write("Введите третье число => ");
string numberSrt3 = Console.ReadLine();
int c = int.Parse(numberSrt3);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальное число: {max}");