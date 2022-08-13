//Задание: Задать номер четверти, показать диапазоны для возможных координат

void RangeQuarter (int numberQuarter) 
{

if (numberQuarter == 1) //Первая четверть
{
    Console.WriteLine("Диапазон чертверти(1): X от >0 до inf, Y от >0 до inf");
}

if (numberQuarter == 2) //Вторая четверть
{
    Console.WriteLine("Диапазон чертверти(2): X от <0 до -inf, Y от >0 до inf");
}

if (numberQuarter == 3) //Третья четверть
{
    Console.WriteLine("Диапазон чертверти(3): X от <0 до -inf, Y от <0 до -inf");
}

if (numberQuarter == 4) //Четвёртая
{
    Console.WriteLine("Диапазон чертверти(4): X от >0 до inf, Y от <0 до -inf");
}

}



Console.Write("Введите номер четверти системы координат (от 1 до 4) ");
int a = int.Parse(Console.ReadLine());

RangeQuarter (a);

