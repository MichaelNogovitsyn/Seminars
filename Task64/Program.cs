/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

System.Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

void NumToOrder(int m, int n)
{
    if (m < n)
    {
        if (m < n)
        {
            System.Console.Write($"{m},");
            NumToOrder(m + 1, n);
        }
    }

    if (m > n)
    {
        if (n < m)
        {
            System.Console.Write($"{m},");
            NumToOrder(m - 1, n);
        }
    }
    
    if (m == n) System.Console.WriteLine($"{m}");
}

NumToOrder(numN, numM);