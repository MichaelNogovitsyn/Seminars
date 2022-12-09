/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int colA = matrixA.GetLength(1);
    int colB = matrixB.GetLength(1);
    int rowC = rowA;
    int colC = colB;
    
    int[,] matrixC = new int[rowC, colC];
    for (int i = 0; i < rowC; i++)
    {
        for (int j = 0; j < colC; j++)
        {
            for (int k = 0; k < colA ; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] matrix1 = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(5, 3, 1, 10);
PrintMatrix(matrix2);
System.Console.WriteLine();

if (matrix1.GetLength(1)==matrix2.GetLength(0))
{
int[,] matrix3=MultiplyMatrix(matrix1,matrix2);
PrintMatrix(matrix3);
}
else System.Console.WriteLine($"Количество столбов первой матрицы не ровняется количеству строк второй");

