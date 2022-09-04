/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

/*
Функция Аккермана:
n+1  			        , m=0
A(m,n)=A(m-1,1)  	    , m>0, n=0
A(m,n)=A(m-1,A(m,n-1))  , m>0, n>0
*/

int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (n > 0)
            return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        else
            return AkkermanFunc(m - 1, 1);
}

int m = 3;
int n = 2;
Console.WriteLine($"M = {m}; N = {n} -> {AkkermanFunc(m, n)}");