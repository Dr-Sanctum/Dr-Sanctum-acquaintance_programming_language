// Задание 5: Написать программу вычисления функции Аккермана

int Foo(int n, int m)
{
    if (n == 0)
    {
       return m + 1;
    }
    else
    {
        if (n != 0 && m == 0)
        {
           return Foo(n - 1, 1);
        }
        else
        {
               return Foo(n - 1, Foo(n, m - 1));
        }
    }


}

Console.WriteLine(Foo(4, 3));
