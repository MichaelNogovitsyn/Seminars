//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num3 > max) max = num3;
if (num2 > max) max = num2;
Console.WriteLine(max);
