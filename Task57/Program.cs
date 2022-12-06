// Составить частотный словарь элементов двкмерного массива. 
// частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входный данных

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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] To1Darray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void CountValue(int[] arr)
{
    int[,] countArray = new int[0, 1];
    int count = 1;
    int num = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1]) count++;
        else
        {
            System.Console.WriteLine($"число {num} встречается {count} раз");
            count = 1;
            num = arr[i];
        }
    }
    System.Console.WriteLine($"число {num} встречается {count} раз");
}

int[,] newMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(newMatrix);
System.Console.WriteLine();
int[] array = To1Darray(newMatrix);
PrintArray(array);

Array.Sort(array);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
CountValue(array);