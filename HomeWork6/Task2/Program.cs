//Задание: Задать двумерный массив следующим правилом: Aₘₙ = m+n
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

void FillArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        } 
    }
}

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());
int[,] Matrix = new int[m,n];

FillArray(Matrix);
PrintArray(Matrix);
