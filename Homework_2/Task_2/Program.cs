// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100, 999);
Console.WriteLine($"Число: {number}");
int numberMN = number / 100 * 10 + number % 10;
Console.WriteLine($"Число без втрой цифры: {numberMN}");