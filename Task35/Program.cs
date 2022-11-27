// задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которрых лежат в отрезке [10,99]

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
int CountRangeDigit(int[] arr,int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max) count++;
    }
    return count;
}

int countRangeDigit=0;
int[] array = CreateArray(123, 0, 100);
PrintArray(array);
countRangeDigit=CountRangeDigit(array,10,99);
Console.WriteLine(countRangeDigit);
