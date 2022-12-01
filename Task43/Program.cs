/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите число b1:");
double numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1:");
double numk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double numk2 = Convert.ToInt32(Console.ReadLine());

double[] FindCrossLines(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    double x;
    double y;
    x = (b2 - b1) / (k1 - k2);
    y = ((k1 * b2) - (k2 * b1)) / (k1 - k2);
    point[0] = x;
    point[1] = y;
    return point;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
System.Console.Write("Точка пересечения:");
PrintArrayDouble(FindCrossLines(numb1, numk1, numb2, numk2));