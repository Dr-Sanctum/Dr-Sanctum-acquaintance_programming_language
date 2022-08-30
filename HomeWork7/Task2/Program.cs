// Задание 2: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
void ArithmeticMeanColumn(int[,] matrix)
{
    float sumColumn;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumn += matrix[j, i];
        }
        Console.WriteLine($" Среднеарифметическое {i} столбца = {sumColumn / matrix.GetLength(0)}.");
    }
}

Console.Clear();

int m, n, search;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArrayRandom(array, 0, 10);
PrintArray(array);

Console.WriteLine();
ArithmeticMeanColumn(array);
