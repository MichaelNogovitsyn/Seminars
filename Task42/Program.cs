// Преобразует десятичное число в двоичное
Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

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

int[] Binary(int number)
{
    int digits = 0;
    int numberB = number;
    while (number > 0)
    {
        number /= 2;
        digits += 1;
    }
    int[] result = new int[digits];

    number = numberB;
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = number % 2;
        number /= 2;
    }
    Array.Reverse(result);
    return result;
}
int[] array = Binary(number);
PrintArray(array);
