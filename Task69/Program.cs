
System.Console.WriteLine("Введите 1 число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2 число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int DegreeNumRec(int numA, int numB)
{
    if (numB == 0) return 1;
    if (numB > 1)
    {
        return numA * DegreeNumRec(numA, numB - 1);
    }
    return numA;
}

int degree = DegreeNumRec(numberA, numberB);
System.Console.WriteLine(degree);