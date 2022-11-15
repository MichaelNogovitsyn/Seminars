// Программа выводит случайное число от 10 -99
//и находит максимаоьную цифру
//76 -> 7
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {firstDigit}");
//else Console.WriteLine($"наибольшая цифра числа {secondDigit}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра числа {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //else return secondDigit;
    // аналог условия if
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

