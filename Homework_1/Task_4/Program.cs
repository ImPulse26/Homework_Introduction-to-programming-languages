//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число от 1 => ");
string numberSrt = Console.ReadLine();
int a = int.Parse(numberSrt);
int begin = 0;
if (begin >= a)
{
    Console.Write($"Введенное число меньше 1.");
}
else
{
    Console.WriteLine($"Чётные числа из диапазона от 1 до {a}:");
}
while (begin < a)
{
    begin++;
    if (begin % 2 == 0) Console.Write($"{begin} ");
}