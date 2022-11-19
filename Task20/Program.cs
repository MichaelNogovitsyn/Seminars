// Программа принимает на входе координаты двух точек
// на выходе находит расстояние между ними в 2D пространстве.
Console.WriteLine("Введите координаты точки XА:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки YA:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки XB:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки YB:");
int yb = Convert.ToInt32(Console.ReadLine());

double Distantion(double xa, double ya, double xb, double yb)
{
    double distantX = xa-xb;
    double distantY = ya-yb;
    double squarX = distantX*distantX;
    double squarY = distantY*distantY;
    double result = Math.Sqrt(squarX+squarY);
    return result;
}
double res = Distantion(xa,ya,xb,yb);
double resRound = Math.Round(res,2, MidpointRounding.ToZero);
Console.WriteLine(resRound);