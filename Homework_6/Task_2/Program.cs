// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();

double Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

double b1 = Prompt($"Введите b1 => ");
double k1 = Prompt($"Введите k1 => ");
double b2 = Prompt($"Введите b2 => ");
double k2 = Prompt($"Введите k2 => ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if ((b1 * k2 - b2 * k1) == 0) Console.WriteLine($"Прямые параллельны и не пересекаются");
else Console.WriteLine($"Точка пересечения: ({x:0.0} ; {y:0.0})");
