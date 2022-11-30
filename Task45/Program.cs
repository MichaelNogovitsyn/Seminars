// Создает копию массива с помощью поэлементного копирования.

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

int[] CoppyArray(int[] arr)
{
    int[] copedArray=new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copedArray[i]=arr[i];
}
return arr;
}

int[] array = CreateArray(6,1,30);
int[] newArray = CoppyArray(array);
PrintArray(array);
PrintArray(newArray);