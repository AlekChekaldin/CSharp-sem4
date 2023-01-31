// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!


int Extent(int a, int b)
{
    int result=1;
    for (int count=1; count<=b; count++)
    {
        result=result*a;
    }
    return result;
}

int ReadConsole (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

Console.Clear();

int a = ReadConsole ("Введите число А: ");

int b = ReadConsole ("Введите число Б: ");

int pow = Extent (a,b);

Console.Write (pow);
