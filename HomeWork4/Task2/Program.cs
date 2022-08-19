//Задание: Написать программу масштабирования фигуры

Console.WriteLine("Задайте целые координаты четырёх вершин фигуры в формате: x1,y1,x2,y2,x3,y3,x4,y4 ");
string stringCoordinate = Console.ReadLine();
Console.Write("Задайте коэфициент масштабирования ");
double coff = double.Parse(Console.ReadLine());

void Skalling(string _string, double _coof)
{
    double[] massCoordinate = new double[8]; //8 цифр координат в строке
    for (int i = 0, k = 0; k < 8; i+=2, k++)
    {
        massCoordinate[k] = _string[i] - '0'; //преобразование символа цыфры в число путём вычитания из символа строки, символ нуля
    }

    foreach (var item in massCoordinate)
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine();
    Console.Write("Отмасштабированная фигура ");
    
    for (int i = 0; i < 8; i++)
    {
        massCoordinate [i] = massCoordinate[i] * coff;
        Console.Write(massCoordinate[i] + ", ");
    }
}

Skalling( stringCoordinate, coff);