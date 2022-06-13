// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число => ");
string srt = Console.ReadLine();
int number = int.Parse(srt);
int result = number % 100 / 10;

 if ((number < 99) || (number > 1000)) {
    Console.WriteLine($"Число {number} меньше 100 или больше 1000");
 }
 else Console.WriteLine($"Вторая цифра числа {number}: {result}");