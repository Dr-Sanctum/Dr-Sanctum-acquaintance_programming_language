// Задание 1: Показать натуральные числа от N до 1, N задано (рекурсия)

void Foo(int n)
{
    int x = n;
    if (x >= 1)
    {
        Console.Write($"{x} ");
        Foo(x - 1);
    }
}

Foo(10);