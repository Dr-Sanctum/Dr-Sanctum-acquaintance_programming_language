﻿/*A. Солдат и бананы
ограничение по времени на тест1 секунда
ограничение по памяти на тест256 мегабайт
вводстандартный ввод
выводстандартный вывод
Солдат хочет купить w бананов в магазине. Ему надо заплатить k 
долларов за первый банан, 2k долларов — за второй и так далее 
(иными словами, за i-й банан надо заплатить i·k долларов).

У него есть n долларов. Сколько долларов ему придется одолжить 
у однополчанина, чтобы купить w бананов?

Входные данные
В первой строке записано три положительных целых числа 
k, n, w (1  ≤  k, w  ≤  1000, 0 ≤ n ≤ 109), 
стоимость первого банана, изначальное количество долларов 
у солдата и количество бананов, которые он хочет купить.

Выходные данные
Выведите единственное целое число — количество долларов, которое 
солдату надо одолжить у однополчанина. Если деньги одалживать не надо, выведите 0.
*/

string given = Console.ReadLine();

int[] numbers = given.Split(' ').Select(int.Parse).ToArray(); //[0] = k, [1] = n, [2] = w

int sumW = 0;
for (int i = 1; i <= numbers[2]; i++)
{
    sumW += numbers[0] * i;
}
if (sumW <= numbers[1])
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(sumW - numbers[1]);
}

