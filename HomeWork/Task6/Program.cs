//Задание: Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Последняя цыфра введённого числа = " + a%10);
