// Программа которая по заданному номеру четверти 
//показывает диаппазон возможных координат в этой четверти 

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string Quarter(int quaterNumber)
{
    if (quaterNumber == 1) return "x>0, y>0";
    if (quaterNumber == 2) return "x<0, y>0";
    if (quaterNumber == 3) return "x<0, y<0";
    if (quaterNumber == 4) return "x>0, y<0";
    else return "такой четверти нет";
}

//string result = Quarter(number);
Console.WriteLine(Quarter(number));
