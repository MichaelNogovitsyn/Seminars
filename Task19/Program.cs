/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятиначное число: ");
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

bool isPalindrom(int number)
{
    // Отзеркалим число
    int digit5 = number % 10;
    int digit4 = number / 10 % 10;
    int digit3 = number / 100 % 10;
    int digit2 = number / 1000 % 10;
    int digit1 = number / 10000 % 10;
    int mirrowedDigit = (10000 * digit5) + (1000 * digit4) + (100 * digit3) + (10 * digit2) + digit1;
    return number == mirrowedDigit ? true : false;
}
// Проверка пятизначного числа
if (LengthInt32(digit)==5) Console.WriteLine(isPalindrom(digit) ? "Да" : "Нет");
else Console.WriteLine("Введено некоректное число");

