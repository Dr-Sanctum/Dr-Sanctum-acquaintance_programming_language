//Задание: Найти кубы чисел от 1 до N

Console.Write("Введите ограничение выводимых кубов чисел ");

int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.Write(Math.Pow(i, 3)+ " ");
    i++;
}