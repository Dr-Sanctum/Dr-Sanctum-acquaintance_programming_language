//Задание: Подсчитать сумму цифр в числе

Console.Write("Введите число ");

int a = int.Parse(Console.ReadLine());

int b = a;
int result = a%10;

if (a > 9)
{
    while (b >= 10)
    {
        b = b/10;
        result += b%10;
    }

     Console.Write("В числе " + a + " сумма цифр = " + result);
}
if (0 < b && b > 10)
{
    Console.Write("В числе " + a + " сумма цифр = " + b);
}
