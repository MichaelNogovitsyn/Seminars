/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
int digits=1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = digits;
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                digits+=3;
            }

        }
        System.Console.WriteLine();
    }
    return matrix;
}

int[,,] newMatrix3D = CreateMatrix3DRndInt(3, 3, 3);
