// Задание 2: В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
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
int[,] Function(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0,0];
    int minColumn = 0;
    int minString = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
                min = matrix [i,j];
                minColumn = i;
                minString = j;
            }
        }
    }

    for (int i = 0, x = 0; i < matrix.GetLength(0); i++)
    {
        if (i == minColumn)
            {
                continue;
            }
        for (int j = 0, y = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minString)
            {
                continue;
            }
            result[x,y] = matrix[i,j];
            y++;
        }
        x++;
    }


    return result;
}

Console.Clear();

int m, n, first, second;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
int[,] matrixResult = new int[m, n];
Console.WriteLine("Матрица:");
FillArrayRandom(array, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Результат:");
matrixResult = Function(array);
PrintArray(matrixResult);