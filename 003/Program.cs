/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/
Console.WriteLine("Wrtie Your number");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Wrtie Your number");
double number2 = Convert.ToInt32(Console.ReadLine());
AkFunction(number1, number2);
Console.WriteLine($"{AkFunction(number1, number2)}");

double AkFunction(double a, double b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return AkFunction(a - 1, 1);
    if (a > 0 && b > 0) return AkFunction(a - 1, AkFunction(a, b - 1));
    return AkFunction(a, b);
}

