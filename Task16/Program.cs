// Программа принимает на вход 2 числа и выводит, является ли первое число квадратом второму
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Sqare(int num1, int num2)
{
    if (num1*num1==num2) return true;
    else return false;
}
bool result = Sqare(num1,num2);
Console.WriteLine( result ? "Да" : "Нет");
