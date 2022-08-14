//Задание: Найти сумму чисел одномерного массива стоящих на нечетной позиции

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
}

void nonEvenNumberIndexSum(int[] _array)
{
    int nonEvenNumberIndexSum = 0;
 for (int i = 1; i < _array.Length; i+=2)
 {
    nonEvenNumberIndexSum += _array[i];
 }

Console.WriteLine();
Console.WriteLine("Cумма чисел массива с нечётным индексом = " + nonEvenNumberIndexSum);
}

FillAndViewArray(array);

nonEvenNumberIndexSum(array);