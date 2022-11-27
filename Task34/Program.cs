/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
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

int countEvenDigit(int[] arr)
{
    int countEvenDigit=default;
    for (int i = 1; i < arr.Length; i+=2)
    {
        countEvenDigit++;
    }
return countEvenDigit;
// А можно проще countEvenDigit=arr.Length/2;

}
int[] array = CreateArray(6,99,1000);
PrintArray(array);
System.Console.WriteLine(countEvenDigit(array));