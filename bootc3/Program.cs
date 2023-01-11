// See https://aka.ms/new-console-template for more information
int n=5;
int[,] matrix = new int[n,n]; 
Console.WriteLine("Hello, World!");
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
         matrix[i,j]=(i+j)*(j+1);
         matrix[j,i]=(i+j)*(j+1);
    }

}

//Print
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
         System.Console.Write(matrix[i,j]);
         System.Console.Write("\t");
    }
System.Console.WriteLine();
}