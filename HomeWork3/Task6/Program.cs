//Задание: В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

void FillAndViewArray( int[] _array)
{
for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(0,500);
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
}

void Counter(int[] _array)
{
    int counter = 0;
 foreach (var item in _array)
 {
    if (item >= 10 && item <= 99)
    {
        counter++;
    }
    
 }

Console.WriteLine();
Console.WriteLine("Количество элементов от 10 до 99 = " + counter);
}

FillAndViewArray(array);

Counter(array);