/* I1.1. Рассчитать значение у при заданном значении х:
y=sin(x) при x>0 или y=cos(x) в противном случае. */
System.Console.Write("Enter x:");
double x = Convert.ToDouble(Console.ReadLine());
double y = 0;
if (x > 0)
{
    y = Math.Cos(x);
}
else { y = Math.Sin(x); }

System.Console.WriteLine(y);