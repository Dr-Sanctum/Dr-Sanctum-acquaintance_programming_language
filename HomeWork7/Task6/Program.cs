//Задание 6: В прямоугольной матрице найти строку с наименьшей суммой элементов.
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine(" ");
    }

}
void FillArrayRandom(int[,] matrix, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
}
void MinSumString(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    int minSum = sum[0];
    int minString = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (minSum > sum[i])
        {
            minSum = sum[i];
            minString = i;
        }
    }
    Console.WriteLine($"Строкой с минимальной суммой ({minSum}) является строка - {minString + 1}");
}

Console.Clear();

int m, n, first, second;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];
FillArrayRandom(array, 0, 10);
PrintArray(array);

Console.WriteLine();
MinSumString(array);