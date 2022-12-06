/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */

System.Console.WriteLine("Введите первое число позиции элемента: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число позиции элемента: ");
int colMatrix = Convert.ToInt32(Console.ReadLine());

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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

int ElementMatrix(int[,] matrix, int row, int column)
{
    if (row < 0 || column < 0) return -1000;
    else if (row <= matrix.GetLength(0) -1|| column <= matrix.GetLength(1)-1)
        return matrix[row, column];
    else return -1000;
}

int[,] array = CreateMatrixRndInt(4, 3, 0, 100);
PrintMatrix(array);
int element = ElementMatrix(array, rowMatrix, colMatrix);
if (element != -1000)
    System.Console.WriteLine($"\nЗначение элемента = {element}");
else System.Console.WriteLine("\nТакого элемента нет");