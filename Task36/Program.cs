/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int sumEvenElements(int[] arr)
{
    int sumEvenElements = default;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumEvenElements += arr[i];
    }
    return sumEvenElements;

}
int[] array = CreateArray(4, 0, 100);
PrintArray(array);
System.Console.WriteLine($"сумма нечетных элементов массива =  { sumEvenElements(array)}");