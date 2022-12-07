// Задайте двумерный массив из целых чисел.
// Напишите программу которая удалит строку и столбец, 
// на пересечении которых расположени наименьший элемент массива

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

int[] FindMinIndexMatrix(int[,] matrix)
{
    int[] indexArray = new int[2];
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                minI = i;
                minJ = j;
            }
        }
    }

    indexArray[0] = minI;
    indexArray[1] = minJ;
    return indexArray;
}

int[,] DeleteRowColMatrix(int[,] matrix, int numRow, int numColumn)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[,] matrix2 = new int[row - 1, column - 1];
    for (int i = 0, k = 0; i < row-1; i++, k++)
    {
        if (k == numColumn) k++;
        for (int j = 0, l = 0; j < column-1; j++, l++)
        {

            if (l == numRow) l++;
            matrix2[i, j] = matrix[k, l];
        }

    }
    return matrix2;
}

int[,] Array = CreateMatrixRndInt(4, 4, 0, 100);
PrintMatrix(Array);
System.Console.WriteLine();
int[] indexArr = FindMinIndexMatrix(Array);
System.Console.WriteLine($"{indexArr[0]} {indexArr[1]}");
System.Console.WriteLine();
int indexRow=indexArr[0];
int indexCol=indexArr[1];
int[,] modifiedArray = DeleteRowColMatrix(Array, indexRow, indexCol);
PrintMatrix(modifiedArray);