//Задание 1: В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void PrintArray(int[,] matrix){
  for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine(" ");
    }
    
}
void FillArrayRandom(int[,] matrix, int min, int max){
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
}
void searchNumber(int[,] matrix, int number)
{
    int i = 0, j = 0;
    bool found = false;
    for (; i < matrix.GetLength(0); i++ )
    {

        for(; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number)
            {
                found = true;
            }
        }
    }

        if (found)
        {
           Console.WriteLine($"Число {number} имеется в массиве на позиции {i},{j}");
        }
        else
        {
           Console.WriteLine($"Числа {number} нет в массиве");
        }
}

Console.Clear();

int m, n, search;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
search = int.Parse(Console.ReadLine());


int[,] array = new int[m,n];
FillArrayRandom(array, 0, 10);
PrintArray(array);

Console.WriteLine();
searchNumber(array, search);
