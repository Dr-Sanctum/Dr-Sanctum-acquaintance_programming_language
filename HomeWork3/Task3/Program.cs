//Задание: Написать программу замену элементов массива на противоположные

int[] array = new int[10];


void FillAndViewArray( int[] _array)
{

for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(-9,9);
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
}

void ReverseArray (int[] _array)
{
    int temp = 0;
    for (int i = 0; i < _array.Length; i++)
    {
       _array[i] = _array[i]*-1;
    }
}

FillAndViewArray(array);

ReverseArray (array);

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

Console.WriteLine();

