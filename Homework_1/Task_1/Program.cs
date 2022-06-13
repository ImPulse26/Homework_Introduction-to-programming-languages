// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число => ");
string numberSrt1 = Console.ReadLine();
int a = int.Parse(numberSrt1);
Console.Write("Введите второе число => ");
string numberSrt2 = Console.ReadLine();
int b = int.Parse(numberSrt2);
int max = a;
if (a > max)
{
    Console.WriteLine($"Большее число {a}");
    Console.WriteLine($"Меньшее число {b}");
}

if (b > max)
{
    Console.WriteLine($"Большее число {b}");
    Console.WriteLine($"Меньшее число {a}");
}
