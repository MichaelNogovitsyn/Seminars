// Задайте массив. Напишите программу которая определяет присутствует ли
// данное число в массиве.

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
bool isContainDigit(int[] arr,int digit)
{
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i]==digit) return true;
    }
    return false;
}

int[] array = CreateArray(10,-10,10);
PrintArray(array);
Console.WriteLine(isContainDigit(array,5) ? "ДА" : "Нет");
