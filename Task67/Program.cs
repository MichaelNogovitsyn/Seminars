// Программа которая принимает на вход число и возвращает сумму его цифр.
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumRec(int num)
{
    if (num / 10 > 0) 
    {
        return num % 10 + SumNumRec(num / 10);
    }
    return num % 10;
}

int sum = SumNumRec(number);
System.Console.WriteLine(sum);