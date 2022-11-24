﻿/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number= -number;

int SumDigits(int num)
{
    int sumDigits = 0;
    while (num > 0)
    {
        sumDigits = sumDigits + num % 10;
        num = num / 10;
    }
    return sumDigits;
}
Console.WriteLine(SumDigits(number));
