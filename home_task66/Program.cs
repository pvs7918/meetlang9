/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SummNumbers(int m, int n)
{
    if (m == n)
        return m;
    return m + SummNumbers(m + 1, n);
}

int m = 4;
int n = 8;

Console.WriteLine($"M = {m}; N = {n} -> {SummNumbers(m, n)}");