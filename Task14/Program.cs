// Программа которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

bool Multyplicity7and23(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    else return false;
}

bool result=Multyplicity7and23(number);
Console.WriteLine(result ? "Кратно" : "Некратно");

