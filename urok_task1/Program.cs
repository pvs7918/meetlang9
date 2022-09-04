// пример рекурсии - иготовление матрешки

void MatreshkaMaster(int size)
{
    if (size == 1)
    {
        Console.WriteLine("Last matreshka: " + size);
        return;
    }
    Console.WriteLine("Start matreshka: " + size);
    MatreshkaMaster(size -1);
    Console.WriteLine("End matreshka: " + size);
    return;
}

MatreshkaMaster(6);