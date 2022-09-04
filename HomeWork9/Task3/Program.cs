// Задание 3: Найти сумму элементов от M до N, N и M заданы (рекурсия)

int Foo(int m, int n)
{
    int sum = + m;
    if (m < n)
    {
        return sum += Foo(m + 1, n);
    }
    else
    {
        return sum;
    }
}

Console.WriteLine(Foo(1, 5));
