//Задание: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


void CrossPoint()
{
int k1 = 10;
int k2 = 0;
int b1 = 1;
int b2 = -3;

double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;

Console.WriteLine($"Точка пересечения прямых - ({x},{y})");
}

CrossPoint();