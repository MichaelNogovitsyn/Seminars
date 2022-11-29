// Принимает на вход 3 числа и проверяет, 
//может ли сухествовать треугольник с сторонами такой длины
Console.WriteLine("Введите сторону А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C:");
int c = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int numA, int numB, int numC)
{
if (numA<numB+numC&&numB<numA+numC&&numC<numB+numA) return true;
else return false;
}
System.Console.WriteLine(IsTriangle(a,b,c)?"Является" : "Нет" );