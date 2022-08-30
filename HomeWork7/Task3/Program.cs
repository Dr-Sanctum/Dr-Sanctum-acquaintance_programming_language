// Задание 3: Написать программу, которая обменивает элементы первой строки и последней строки
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
void ExchangeStringArray(int[,] matrix, int firstString, int SecondString)
{
    int[] tempFirstStringArray = new int[matrix.GetLength(1)];
    int[] tempSecondStringArray = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tempFirstStringArray[i] = matrix[firstString - 1, i];
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tempSecondStringArray[i] = matrix[SecondString - 1, i];
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[firstString - 1, i] = tempSecondStringArray[i];
        matrix[SecondString - 1, i] = tempFirstStringArray[i];
    }
}

Console.Clear();

int m, n, first, second;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
n = int.Parse(Console.ReadLine());
Console.Write("Введите номер первой строки для замены ");
first = int.Parse(Console.ReadLine());
Console.Write("Введите номер второй строки для замены ");
second = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArrayRandom(array, 0, 10);
PrintArray(array);

Console.WriteLine();
ExchangeStringArray(array, first, second);
PrintArray(array);