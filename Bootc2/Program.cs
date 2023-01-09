// Поиск максимума из 3х подряд чисел массива.
int size=10;
int m =3;
int[] array = Enumerable.Range(1,size)
                        .Select(item=> Random.Shared.Next(10))
                        .ToArray();

System.Console.WriteLine($"[{string.Join(", ", array)}]");

int max=0;

for (int i = 0; i < array.Length-m; i++)
{
    int t=0;
    for (int j = i; j < i+m; j++)
    {
        t=t+array[j];
    }
    if (t>max) max=t;
}
System.Console.WriteLine(max);