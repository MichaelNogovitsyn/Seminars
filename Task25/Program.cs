﻿/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

int Degree(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    if (numB == 0) return 1;
    return result;
}
if (numB >= 0) System.Console.WriteLine(Degree(numA, numB));
else System.Console.WriteLine("Число В должно быть натуральным");
