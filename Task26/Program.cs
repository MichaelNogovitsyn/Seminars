﻿// Принимает на вход число и возвращает кол-во цифр в числе
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

// функция находит количество цифр в числе(Int32).
int LengthInt32(int n)
{
    if (n < 0)
    {
        n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
    }
    if (n < 10) return 1;
    if (n < 100) return 2;
    if (n < 1000) return 3;
    if (n < 10000) return 4;
    if (n < 100000) return 5;
    if (n < 1000000) return 6;
    if (n < 10000000) return 7;
    if (n < 100000000) return 8;
    if (n < 1000000000) return 9;
    return 10;
}
Console.WriteLine(LengthInt32(digit));
