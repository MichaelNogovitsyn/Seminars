// Выдает сумму чисел от 1 до А
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine(SumDigits(number));