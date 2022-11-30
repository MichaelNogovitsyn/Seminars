// не используя рекурсии, выведите первые N чисел
//Фибоначчи. Первые два числа 0 и 1

Console.WriteLine("Ведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string Fibonacci(int numN)
{
    string rawFib = default;
    rawFib += "0 1 ";
    int count = 2;
    int numfibonacci = 2;
    int num1=1;
    int num2=0;
    while (count < numN)
    {
        numfibonacci = (num1) + (num2);
        num2=num1;
        num1=numfibonacci;
        rawFib += $"{numfibonacci} ";
        count++;
    }
    return rawFib;
}
string Fib = Fibonacci(N);
System.Console.WriteLine(Fib);