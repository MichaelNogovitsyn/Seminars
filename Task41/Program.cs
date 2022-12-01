/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите М чисел через пробел: 1 2 3 4 5");

string stringDigits = Console.ReadLine();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
// Считает количество определенных символов в строке
int CountCharInString(string str, char symb)
{
    int count = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == symb) count++;
    }
    return count;
}

int[] StringToInt(string str, int size, char symb)
{
    int[] digits = new int[size];
    string tempSTR = "";
    char ch = symb;
    int j = 0; // индекс числа (порядковый номер) 
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ch)
        {
            digits[j] = Convert.ToInt32(tempSTR);
            tempSTR = "";
            i++; // пропускаем разделяющий символ;
            j++; // переходим на следующее число;
        }
        tempSTR += str[i];

        if (i == str.Length - 1) // записываем последнее число
            digits[j] = Convert.ToInt32(tempSTR);
    }
    return digits;
}

int CountNumMoreZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int countNum = CountCharInString(stringDigits, ' ');
int[] digitsArray = StringToInt(stringDigits, countNum, ' ');
int countMoreZero = CountNumMoreZero(digitsArray);
System.Console.WriteLine($"чисел в строке : {countNum}");
System.Console.Write("полученный массив чисел ");
PrintArray(digitsArray);
System.Console.WriteLine($"Чисел больше ноля: {countMoreZero}");