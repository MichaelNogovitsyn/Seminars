// Программа выводит числа от m до n

void OrderNum(int m, int n)
{
    if (m < n)
    {
        if (m < n)
        {
            System.Console.WriteLine(m);
            OrderNum(m + 1, n);
        }
    }

    if (m > n)
    {
        if (n < m)
        {
            System.Console.WriteLine(m);
            OrderNum(m - 1, n);
        }
    }
    
    if (m == n) System.Console.WriteLine(m);
}

OrderNum(10, 0);