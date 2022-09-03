// Задание 2: Показать натуральные числа от M до N, N и M заданы (рекурсия);

void Foo(int m, int n)
{
    int x = m;
    if (x <= n)
    {
        Console.Write($"{x} ");
        Foo(x + 1, n);
    }
}

Foo(5, 20);