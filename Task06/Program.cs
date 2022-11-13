//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
if(num==0) Console.WriteLine("НЕТ"); // исключаем число 0;
else if (num%2==0) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");