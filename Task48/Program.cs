// Задайте двумерный массив размера m*n, 
// каждый элемент массива находится по формуле: Amn=m+n.
//Выедите полученный массив.
int[,] CreateMatrixRndInt(int n, int m)
{
    int[,] matrix = new int[n, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = m+n;
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
            if (j < matrix.GetLength(1)-1) Console.Write($"{matrix[i,j],4}, ");
            else Console.Write($"{matrix[i,j],4}");
        }
        Console.WriteLine(" ]");
    }
}
int[,] array=CreateMatrixRndInt(4,5);
PrintMatrix(array);