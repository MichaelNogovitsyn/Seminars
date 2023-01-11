
// Поиск максимума из 3х подряд чисел массива.
using System.Diagnostics;
int size = 1000_000;
int m = 1_0000;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

//System.Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();


int max = 0;

for (int j = 0; j < m; j++) max += array[j];
int t = max;
for (int i = 1; i < array.Length-m; i++)
{
    t=t-array[i-1] + array[i+m-1];
            if (t > max) max = t;
}
sw.Stop();
System.Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
System.Console.WriteLine(max);