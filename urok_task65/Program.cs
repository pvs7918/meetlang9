/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные
числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void GetNextNumber(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m == n)
        Console.Write($"{m}");
    else
        Console.Write($"{m}, ");

    GetNextNumber(m + 1, n);
    return;
}

int m=4;
int n =8;
Console.Write($"M = {m}, N = {n} -> ");
GetNextNumber(m,n);