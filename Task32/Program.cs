// Программа замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наооборот
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

int[] turnArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=-arr[i];
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

int[] array = CreateArray(10,-10,10);
PrintArray(array);
turnArray(array);
PrintArray(array);