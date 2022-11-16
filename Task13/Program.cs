/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
 */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return -1;
    }
    // уменьшаем разряды числа до 3х.
    while (number > 999)
    {
        number = number / 10;
    }

    int result = number % 10;
    return result;
}
Console.WriteLine(ThirdDigit(number));