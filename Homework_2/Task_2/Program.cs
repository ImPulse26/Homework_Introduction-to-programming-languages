// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите трехзначное число => ");
string srt = Console.ReadLine();
int number = int.Parse(srt);
int result = number % 100 / 10;

 if ((number < 99) || (number > 1000)) {
    Console.WriteLine($"Число {number} меньше 100 или больше 1000");
 }
 else Console.WriteLine($"Вторая цифра числа {number}: {result}");