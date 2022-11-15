// Программа принимает на вход 2 числа и выводит, является ли первое число кратным второму
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multyplicity(int num1, int num2)
{
    if (num1 % num2 == 0) return true;
    else return false;
}
bool result = Multyplicity(num1,num2);
Console.WriteLine( result ? "Кратно" : "некратно");