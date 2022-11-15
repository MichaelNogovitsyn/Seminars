// Программа выводит случайное трехзначное число и удаляет вторую цифруч эото числа
Console.WriteLine("Hello, World!");

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число{number}");

int delaySecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int digit = firstDigit * 10 + secondDigit;
    return digit;
}
Console.WriteLine(delaySecondDigit(number));
