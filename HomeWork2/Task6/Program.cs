//Задание: Найти сумму чисел от 1 до А

Console.Write("Введите последнее число для суммирования предыдущих чисел ");

int a = int.Parse(Console.ReadLine());
int i = 1;
int result = 0;
while (i <= a)
{
    result += i;
    
    i++;
}
Console.Write("Сумма чисел до " + a + " = " + result);