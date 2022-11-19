// Программа принимает на вход число N и выводит 
// квадраты чисел от 1 до N;
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

void tableOFsqrt(int n)
{
for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"{i} -> {i*i} ");  
}
}

tableOFsqrt(n);