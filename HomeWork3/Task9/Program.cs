//Задание: В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[10];

void FillAndViewArray( double[] _array)
{
for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().NextDouble()*10;
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
    Console.WriteLine();
}

void Diff(double[] _array)
{
    double min = _array[0];
    double max = _array[0];
 for (int i = 1; i < _array.Length; i++)
 {
    if (_array[i]> max)
    {
        max = _array[i];
    }
    if (_array[i]< min)
    {
        min = _array[i];
    }
 }
 Console.WriteLine("Минимальное = " + min);
 Console.WriteLine("Максимальное = " + max);
 Console.WriteLine("Разница = " + (max - min));
}

FillAndViewArray(array);

Diff(array);