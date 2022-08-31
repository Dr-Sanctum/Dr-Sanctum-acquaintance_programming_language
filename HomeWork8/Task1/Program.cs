//Задание 1: Найти произведение двух матриц
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
int[,] MatrixmMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0 ; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                 result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
               
        }
    }
    return result;
}

Console.Clear();

int m, n, first, second;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
n = int.Parse(Console.ReadLine());


int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
int[,] matrixMulti = new int[m, n];
Console.WriteLine("Первая матрица:");
FillArrayRandom(array1, 0, 10);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
FillArrayRandom(array2, 0, 10);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Резальтат умножения:");
matrixMulti = MatrixmMultiplication(array1, array2);
PrintArray(matrixMulti);