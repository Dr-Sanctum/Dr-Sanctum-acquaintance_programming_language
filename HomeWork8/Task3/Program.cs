// Задание 3: Сформировать трехмерный массив не повторяющимися двузначными 
// числами показать его построчно на экран выводя индексы соответствующего элемента

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"Индекс - ({i},{j},{k}) {matrix[i, j, k]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void Foo(int[,,] matrix)
{
    var rand = new Random();
    int tempRandom;
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int counter = 0;
    bool x = true;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                for (;;)
                {
                    x = true;
                    tempRandom = rand.Next(10, 100); // двузначные числа от 10 до 99
                    for (int z = 0; z < temp.Length; z++)
                    {
                        if (tempRandom == temp[z])
                        {
                            x = false;
                            break;
                        }
                    }
                    if (x)
                    {
                        temp[counter] = tempRandom;
                        counter++;
                        break;
                    }
                }
                matrix[i, j, k] = tempRandom;
            }
        }
    }
}
Console.Clear();

int m, n, l;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
n = int.Parse(Console.ReadLine());
Console.Write("Введите количество блоков строка-столбец ");
l = int.Parse(Console.ReadLine());

int[,,] array = new int[m, n, l];
Console.WriteLine("Трёхмерный массив:");
Foo(array);
PrintArray(array);
