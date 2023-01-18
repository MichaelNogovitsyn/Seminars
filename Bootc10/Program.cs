// See https://aka.ms/new-console-template for more information

public static class Sorting
{
    public static int[] SortCounting(int[] collection)
    {
        int[] array = GeneratorArray(10);
        System.Console.WriteLine(string.Join(',', array));
        int size = collection.Length;

        int max = collection[0];
        for (int i = 0; i < size; i++)
            if (collection[i] > max) max = collection[i];

        int[] counter = new int[max + 1];
        for (int i = 0; i < size; i++)
            counter[collection[i]]++;
  


        static int[] GeneratorArray(int size)
        {
            Random _rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _rand.Next(0, 10);
            }
            return arr;
        }

        return collection;
    }
}