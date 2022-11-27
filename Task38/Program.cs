/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i]=Math.Round(rnd.NextDouble()*(max-min)+min,1);
    }
    return arr;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceMaxMin(double[] arr)
{
double minArr = arr[0]; 
double maxArr = arr[0];  
double diff = default;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]<minArr) minArr=arr[i];
    if (arr[i]>maxArr) maxArr=arr[i];
}
diff=maxArr-minArr;
return diff;
}
double[] array = CreateArrayRndDouble(5,1,100);
double difference = Math.Round(DifferenceMaxMin(array),1);
PrintArrayDouble(array);
Console.WriteLine($"Разница между max и min = {difference}"); 