// Программа которая на входе принимает число N, а на выходе
//показывает все целые числа от -N до N.
//4-> -4,3,2,1,0,1,2,3,4
Console.WriteLine("Hello, World!");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = -N; count <= N; count++)
{
    Console.WriteLine(count);
}