/* // /* Программа выводит массив
заполненный нулями и единицами в случайном порядке */ 

Console.WriteLine("Enter array lengh ");
int l= Convert.ToInt32(Console.ReadLine());

int[] array= new int[l];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i]= rnd.Next(0,2);
    Console.Write($"{array[i]} ");
}
