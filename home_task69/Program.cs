/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int MyPow(int m, int n)
{
    if (n == 1)
        return m;
    return m * MyPow(m, n - 1);
}

int A = 2;
int B = 3;

Console.WriteLine($"A = {A}; B = {B} -> {MyPow(A, B)}");