﻿/*
1. arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
2. pivot = arr[6]  (опорный элемент)
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
QuickSort(arr, 0, arr.Length - 1);
Console.Write($"Отсортированный массив {string.Join(", ", arr)}");

static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}
static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    //arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
    int pivotIndex = minIndex - 1; System.Console.WriteLine(minIndex - 1);
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
            System.Console.WriteLine(string.Join(',',inputArray));
        }
       
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    System.Console.WriteLine($"pivotIndex = {pivotIndex}");
    System.Console.Write("Swap2: ");
    System.Console.WriteLine(string.Join(',',inputArray));
    return pivotIndex;
}
static void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}