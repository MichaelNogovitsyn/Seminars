/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.WriteLine("Введите цифру соответствующюю дню недели от 1 до 7");

int number = Convert.ToInt32(Console.ReadLine());

bool weekend(int dayNumber)
{
    return dayNumber == 6 | dayNumber == 7 ? true : false;
}

bool result = weekend(number);
Console.WriteLine(result ? "Да" : "Нет");