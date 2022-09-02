// Задание 4:Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            else
            {
                Console.Write($"{string.Empty,4}");
            }
        }
        Console.WriteLine(" ");
    }
}


int m;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());

int[,] trianglePaskal = new int[m, m * 2 + 1];
double x = trianglePaskal.GetLength(1) / 2;
for (int i = 0; i < trianglePaskal.GetLength(1); i++)
{
    if (i == Convert.ToInt32(Math.Round(x, 0, MidpointRounding.ToPositiveInfinity)))
    {
        trianglePaskal[0, i] = 1;
    }
    else
    {
        trianglePaskal[0, i] = 0;
    }
}

for (int i = 1; i < trianglePaskal.GetLength(0); i++)
{
    for (int j = 0; j < trianglePaskal.GetLength(1); j++)
    {
        if (j > 0 && j < trianglePaskal.GetLength(1) - 1)
        {
            trianglePaskal[i, j] = trianglePaskal[i - 1, j - 1] + trianglePaskal[i - 1, j + 1];
        }
    }
}

PrintArray(trianglePaskal);
