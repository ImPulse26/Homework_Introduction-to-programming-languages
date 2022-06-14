// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7) => 15,84 ||  A(7,-5,0); B(1,-1,9) => 11,53 
Console.Clear();
int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите x1 => ");
int y1 = Prompt("Введите y1 => ");
int z1 = Prompt("Введите z1 => ");
int x2 = Prompt("Введите x2 => ");
int y2 = Prompt("Введите y2 => ");
int z2 = Prompt("Введите z2 => ");

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double distance = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine($"Расстояние {distance} => ");