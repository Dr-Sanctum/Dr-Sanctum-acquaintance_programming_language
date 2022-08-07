//Задание: Показать числа от -N до N
Console.Write("Введите ограничение выводимых чисел ");
int a = int.Parse(Console.ReadLine());
int x = -a;

while (x <= a )
{
    Console.Write(x + " ");
    x++;
}