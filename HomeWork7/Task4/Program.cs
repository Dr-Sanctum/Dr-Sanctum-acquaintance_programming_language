//Задание 4: Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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
void SortString2DArrayDescending(int[,] matrix)
{
    int temp = 0;
    int tempCounter = 0;
    int counter = 0;
    int min =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = matrix[i,0];
            counter = j;
            tempCounter = 0;
            for (int k = 1; k < matrix.GetLength(1) - counter; k++)
            {
                if (matrix[i,k] < min)
                {
                    min = matrix[i,k];
                    tempCounter = k;
                }
            }
            temp = matrix[i,matrix.GetLength(1) - 1 - counter];
            matrix[i,matrix.GetLength(1) - 1 - counter] = min;
            matrix[i,tempCounter] = temp;
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
SortString2DArrayDescending(array);
PrintArray(array);