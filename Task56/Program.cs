/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} ");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("|");
    }
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

int[] SumRowArray(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[] sumRow = new int[row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
}

int MinElementArray(int[] array)
{
    int minIndex = 0;
    int min = array[0]; ;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            minIndex = i;
            min = array[i];
        }
    }
    return minIndex;
}

int[,] rndMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(rndMatrix);
System.Console.WriteLine();
int[] sumRowArray = SumRowArray(rndMatrix);
PrintArray(sumRowArray);
int indexRow = MinElementArray(sumRowArray);
System.Console.WriteLine($"\nОтвет: {indexRow + 1} строка");