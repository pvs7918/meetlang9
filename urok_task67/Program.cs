/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SummDigits(int n)
{
    if (n == 0)
        return 0;
    return n % 10 + SummDigits(n / 10);
}

bool AutoTest()
{
    if (SummDigits(555555554)!=44)
    {
        Console.WriteLine("test 1");
        return false;
    }
    if (SummDigits(0)!=0)
        return false;
    if (SummDigits(1)!=1)
        return false;    
    
    return true;    
}

int n = 555555554;
Console.Write($"{n} -> {SummDigits(n)}");

if (AutoTest())
    Console.WriteLine("Автотест пройден успешно");
else
    Console.WriteLine("Автотест не пройден");

