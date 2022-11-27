/* // Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элеменот, 
воторой и предпоследний и.т.д. 
Результат запишите в новом массиве. */

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

int[] MultiplyElementsArray(int[] arr) 
{
    int size = arr.Length/2;
    if (arr.Length%2>0) size+=1;
    int[]  arrayMultiply=new int[size];
    for (int i = 0; i < (arr.Length)/2; i++)
    {
       arrayMultiply[i]=arr[i]*arr[arr.Length-1-i];
    }
return arrayMultiply;
}
int[] array = CreateArray(5,1,10);
PrintArray(array);
int[] resultArray=MultiplyElementsArray(array);
PrintArray(resultArray);