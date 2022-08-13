//Задание: Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите последнее число для умножения предыдущих чисел ");

int a = int.Parse(Console.ReadLine());
int i = 1;
double result = 1;
while (i <= a)
{
    result = result * i;
    
    i++;
}
Console.Write("Произведение чисел до (факториал) " + a + " = " + result);