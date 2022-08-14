//Задание: Определить, присутствует ли в заданном массиве, некоторое число

int[] array = new int[10];

void FillAndViewArray( int[] _array)
{
for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(0,20);
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
}

void SearchNumberOfArray(int[] _array, int a)
{
 for (int i = 0; i < _array.Length; i++)
 {
        if (_array[i] == a)
    {
        Console.WriteLine();
        Console.WriteLine($"Число {a} присутствует в массиве");
        break;
    }
    if (i == _array.Length-1)
    {
        Console.WriteLine();
        Console.WriteLine($"Число {a} отсутствует в массиве");
    }
 }
}

FillAndViewArray(array);

SearchNumberOfArray(array, 10);