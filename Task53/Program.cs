// Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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

int [,] ReplaceRowArray(int[,] matrix)
{
    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
    int lastRow= rowLength-1;
    int firstRow=0;
    int tempDigit;
  for (int j = 0; j < colLength; j++)
  {
    tempDigit=matrix[firstRow,j];
    matrix[firstRow,j] = matrix[lastRow,j];
    matrix[lastRow,j]=tempDigit;
  }  
  return matrix;
}
int[,] newMatrix = CreateMatrixRndInt(4,3,0,10);
PrintMatrix(newMatrix);
System.Console.WriteLine();
int[,] ChangedMatrix = ReplaceRowArray(newMatrix);
PrintMatrix(ChangedMatrix);
