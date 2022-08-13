//Задание: Найти расстояние между точками в пространстве 2D/3D

double Distance2D(int x1, int y1, int x2, int y2)
{
return  Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
}

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
return  Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
}

Console.WriteLine ("Введите 2D чтобы определять расстояние между точками в двумерном пространстве");
Console.WriteLine ("Введите 3D чтобы определять расстояние между точками в трёхмерном пространстве");
string a = Console.ReadLine();

if (a == "2D")
{
    Console.WriteLine ("Введите координату X  первой точки");
    int x1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Y  первой точки");
    int y1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату X  второй точки");
    int x2 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Y  второй точки");
    int y2 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Расстояние между двумя точками = " + Distance2D(x1, y1, x2, y2));
}
if (a == "3D")
{
    Console.WriteLine ("Введите координату X  первой точки");
    int x1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Y  первой точки");
    int y1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Z  первой точки");
    int z1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату X  второй точки");
    int x2 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Y  второй точки");
    int y2 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите координату Z  второй точки");
    int z2 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Расстояние между двумя точками = " + Distance3D(x1, y1, z2, x2, y2, z2));
}