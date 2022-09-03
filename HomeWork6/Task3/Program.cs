//Задание: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
            matrix[i, j] = rand.Next(min, max + 1);
    }
}

void ChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j], 2));
            }
        }
    }
}

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());
int[,] Matrix = new int[m, n];

FillArrayRandom(Matrix, 0, 10);

PrintArray(Matrix);
ChangeArray(Matrix);
Console.WriteLine();
PrintArray(Matrix);