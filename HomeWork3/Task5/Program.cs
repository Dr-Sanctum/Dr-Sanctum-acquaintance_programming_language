//Задание: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

void FillAndViewArray( int[] _array)
{
for (int i = 0; i < _array.Length; i++)
    {
        _array[i] = new Random().Next(0,1000);
    }

for (int i = 0; i < _array.Length; i++)
    {
        Console.Write($"{_array[i]} ");
    }
}

void Counter(int[] _array)
{
    int evenNumberedCounter = 0;
    int nonEvenNumberedCounter = 0;
 foreach (var item in _array)
 {
    if (item%2 == 0)
    {
        evenNumberedCounter++;
    }
    else 
    {
        nonEvenNumberedCounter++;
    }
 }

Console.WriteLine();
Console.WriteLine("Количество чётных элементов = " + evenNumberedCounter);
Console.WriteLine("Количество нечётных элементов = " + nonEvenNumberedCounter);
}

FillAndViewArray(array);

Counter(array);