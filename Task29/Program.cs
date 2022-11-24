/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */


string RandomArray()
{
    int lengthArray = 8;
    int[] array = new int[lengthArray];
    Random rnd = new Random();
    string str = "[";
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        str = str + $"{array[i]},";
    }
    int end = str.Length - 1;  //конец строки
    str=str.Remove(end); // удалим лишнюю запятую
    return str + "]";
}
Console.WriteLine(RandomArray());
