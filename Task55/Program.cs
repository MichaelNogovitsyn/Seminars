// Задайте двумерный массив. Напишите программу, которя заменяет строки на столбцы. 
// В случае, если это не возможно, программа должна вывести сообщение для пользователя.

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

void ReplaceRowsColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[i, j] = matrix[j, i];
        }
    }
}
int[,] newMatrix = CreateMatrixRndInt(3, 3, 0, 10);

PrintMatrix(newMatrix);
System.Console.WriteLine();
if (newMatrix.GetLength(0) == newMatrix.GetLength(1))
{
    ReplaceRowsColumns(newMatrix);
    PrintMatrix(newMatrix);
}
else
    System.Console.WriteLine("Неверный размер матрицы");

