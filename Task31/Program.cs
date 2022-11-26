// Массыв из 12 чисел от -9 до 9;
//найти сумму всех отрицательных и положительных чисел
// Вывести массив
//Console.WriteLine("Hello, World!");

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

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

int GetSumNegative(int[] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
    }
    return sumNegative;
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}


int[] array = CreateArray(12, -9, 9);
PrintArray(array);

Console.WriteLine(GetSumNegative(array));
Console.WriteLine(GetSumPositive(array));

