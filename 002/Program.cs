/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Wrtie Your number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Wrtie Your number");
int number2 = Convert.ToInt32(Console.ReadLine());
Check(number1, number2);
total(number1, number2);

void total(int a, int b)
{
    Console.Write(Sum(a - 1, b));
}
void Check (int a, int b)
{
    if( a<0) 
    { 
        Console.WriteLine("Number cannot be less then 0");
    return;
    }
    if ( b<0)
    {  Console.WriteLine("Number cannot be less then 0");
    return;
    }
}

int Sum(int a, int b)
{
    
    int summ = a;
    if (a == b)
        return 0;
    else
    {
        a++;
        summ = a + Sum(a,b);
        return summ;
    }
}