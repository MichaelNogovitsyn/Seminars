// Выдавать название дня недели по заданному номеру
// 3 - среда
// 5 - пятница
Console.WriteLine("Ведите номер дня от 1 до 7");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("понедельник");
else if (num == 2) Console.WriteLine("вторник");
else if (num == 3) Console.WriteLine("среда");
else if (num == 4) Console.WriteLine("четверг");
else if (num == 2) Console.WriteLine("пятница");
else if (num == 2) Console.WriteLine("суббота");
else if (num == 2) Console.WriteLine("воскресение");
else Console.WriteLine("не корректное число");