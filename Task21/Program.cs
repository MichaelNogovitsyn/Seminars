/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки XА:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки YA:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки ZA:");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки XB:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки YB:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки ZB:");
int zb = Convert.ToInt32(Console.ReadLine());

double Distantion(double xa, double ya, double xb, double yb, double za, double zb)
{
    double distantX = xa - xb;
    double distantY = ya - yb;
    double distantZ = za - zb;
    double squarX = distantX * distantX;
    double squarY = distantY * distantY;
    double squarZ = distantZ * distantZ;
    double result = Math.Sqrt(squarX + squarY+squarZ);
    return result;
}
double res = Distantion(xa, ya, xb, yb,za,zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
