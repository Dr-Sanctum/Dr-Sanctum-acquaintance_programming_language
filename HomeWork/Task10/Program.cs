//Задание: Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Задайте число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число для проверки кратности заданному ");
int b = int.Parse(Console.ReadLine());

if ( b%a == 0)
{
    Console.WriteLine("Число " + b + " кратно числу " + a);
}
else
{
    Console.WriteLine("Число " + b + " не кратно числу " + a + ", остаток от деления = " + b%a);
}


