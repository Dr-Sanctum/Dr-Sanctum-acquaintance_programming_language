//Задание: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

void Holiday(int numberDayWeek){
if (numberDayWeek  == 6 || numberDayWeek == 7)
{
    Console.Write("День недели выходной");
} 
if (1 <= numberDayWeek && numberDayWeek < 6 )
{
    Console.Write("День недели будни");
}
}


Console.Write("Введите число от 1 до 7 ");

Holiday(int.Parse(Console.ReadLine()));
