/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
 */
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int result = number / 10 % 10;
    return result;
}
Console.WriteLine($"второе число {SecondDigit(number)}");