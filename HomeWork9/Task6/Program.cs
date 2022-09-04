// Задание 6: Написать программу возведения числа А в целую стень B (рекурсия)

int Foo(int a, int b)
{
    
   
    if (b > 1)
    {
        return a  = Foo(a , b - 1)*a;
    }
    return b == 0 ? 1 : a;
}

Console.WriteLine(Foo(2,0));