/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */
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

int[,] FillSpiralMatrix()
{
    int[,] matrix = new int[4, 4];
    int rows = 3;
    int col = 3;
    int m = 1;
    int i = 0;
    int j = 0;
    matrix[0, 0] = m++;
    for (int n = 0; n < 10; n++)
    {
        if (j < col) { j++; matrix[i, j] = m++; }
        else if (i < rows) { i++; matrix[i, j] = m++; }
        else if (j > 0) { j--; matrix[i, j] = m++; }
        else { rows--; }
        if (i > 0) { i--; matrix[i, j] = m++; }
        else col--;
    }
    return matrix;
}
int[,] newMatrix = FillSpiralMatrix();
PrintMatrix(newMatrix);