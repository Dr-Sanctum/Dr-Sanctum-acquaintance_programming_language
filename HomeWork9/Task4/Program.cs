// Задание 4: Найти сумму цифр числа (рекурсия)

int Foo(int n)
{
    int sum = 0;
    if (n > 10)
    {
        
        return sum + n%10 + Foo(n/10);
    }
    else
    {
        return sum + n;   
    }

}

Console.WriteLine(Foo(44656));