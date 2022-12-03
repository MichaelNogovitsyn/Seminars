// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0);(1;1)))

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
            if (j < matrix.GetLength(1)-1) Console.Write($"{matrix[i,j],4}, ");
            else Console.Write($"{matrix[i,j],4}");
        }
        Console.WriteLine(" ]");
    }
}

int SumDiagonalMatrix(int[,] matrix)
{
    int sum=0;
int length = matrix.GetLength(0)<matrix.GetLength(1) ?matrix.GetLength(0) :matrix.GetLength(1);

for (int i = 0; i < length ; i++)
{
    sum+=matrix[i,i];
}
return sum;
}

int[,] arr = CreateMatrixRndInt(2,4,0,9);
PrintMatrix(arr);
int sumDiag= SumDiagonalMatrix(arr);
System.Console.WriteLine(sumDiag);