//Задание: Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[10];

void FillAndViewArray( int[] _array)
{
for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(0,10);
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
    Console.WriteLine();
}

void Sum(int[] _array)
{
    int result = 0;
 for (int i = 0; i < _array.Length/2; i++)
 {
    result = _array[i] * _array[_array.Length - 1 - i];
    Console.WriteLine("произведение противоположных элементов = " + result);
 }
}

FillAndViewArray(array);

Sum(array);