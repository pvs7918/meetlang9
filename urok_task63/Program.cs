/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void GetNextNumber(int n, int m = 1)
{
    if (m > n)
    {
        Console.WriteLine();
        return;
    }
    if (m == n)
        Console.Write($"{m}");
    else
        Console.Write($"{m}, ");

    GetNextNumber(n, m + 1);
    return;
}

int n = 5;
int m = 1;
Console.Write($"N = {n} -> ");
GetNextNumber(n);