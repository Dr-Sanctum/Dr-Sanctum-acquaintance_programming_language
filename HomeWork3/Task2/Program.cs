//Задание: Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму чётных/нечётных элементов массива

int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,9);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

int SumPositive(int[] _array)
{
int result = 0;

foreach (var item in _array)
{
    if (item%2 ==0)
    {
        result += item;
    }
}

return result;
}

int SumNegative(int[] _array)
{
int result = 0;

foreach (var item in _array)
{
    if (item%2 == 1)
    {
        result += item;
    }
}
return result;
}

Console.WriteLine();
Console.WriteLine("Сумма всех чётных чисел массива = " + SumPositive(array));
Console.WriteLine("Сумма всех нечётных чисел массива = " + SumNegative(array));