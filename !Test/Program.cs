/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];

    int[] digitArray = new int[matrix.Length];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }

        }
        System.Console.WriteLine();
    }
    return matrix;
}

bool CoinsideElementMatrix(int[,,] matrix, int digit)
{
    int coinside = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (digit == matrix[i, j, k]) coinside = 1;
            }
        }
    }
    return coinside == 1 ? true : false;
}

void ReplaceElementMatrix(int[,,] matrix, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (CoinsideElementMatrix(matrix, matrix[i, j, k]))
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                }
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        System.Console.WriteLine();
    }
}

int[,,] newMatrix3D = CreateMatrix3DRndInt(2, 2, 2, 1, 11);
ReplaceElementMatrix(newMatrix3D, 0, 20);
