//Задание: Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray(double[,] matrix){
  for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
        Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine(" ");
    }
    
}

void FillArrayRandom(double[,] matrix){
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.NextDouble()*10;
        } 
    }
}

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());
double[,] doubleMatrix = new double[m,n];

FillArrayRandom(doubleMatrix);
PrintArray(doubleMatrix);