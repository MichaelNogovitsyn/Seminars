public static class Infrastracture
{
    public static int[] CreateArray(this int size, int min=0,int max=10)
    {
        return Enumerable.Range(1,size)
                    .Select(item=>Random.Shared.Next(min,max))
                    .ToArray();
    }
    public static int[] Print(this int[] array)
    {
        System.Console.WriteLine($"[{String.Join(',',array)}]");
        return array;
    }
}