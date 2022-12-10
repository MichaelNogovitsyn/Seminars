/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


System.Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumDigitsRec(int numM, int numN)
{
    if (numN < numM)
    {
        if (numN < numM)
        {
            return numM + SumDigitsRec(numM - 1, numN);
        }
        return numM;
    }

    if (numN > numM)
    {
        return numN + SumDigitsRec(numM, numN - 1);
    }
    return numN;


}


int sumNum = SumDigitsRec(numberM, numberN);
System.Console.WriteLine(sumNum);