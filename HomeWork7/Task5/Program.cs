// Задание 5: Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).


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
void TranspositionMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Матрица не квадратная");
    }
    else
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0 + i; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }
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
TranspositionMatrix(array);
PrintArray(array);