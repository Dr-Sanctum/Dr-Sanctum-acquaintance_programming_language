//Задание: По заданному номеру дня недели вывести его название
string  firstDayoOfTheWeek = "Понедельник",
        secondDayoOfTheWeek = "Вторник",
        thirdDayoOfTheWeek = "Среда",
        fourthDayoOfTheWeek = "Четверг",
        fifthDayoOfTheWeek = "Пятница",
        sixthDayoOfTheWeek = "Суббота",
        seventhDayoOfTheWeek = "Воскресенье";

Console.Write("Введите число от одного до семи ");
int numberDayOfTheWeek = int.Parse(Console.ReadLine()); //От одного до семи

if (numberDayOfTheWeek == 1)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + firstDayoOfTheWeek);
}

if (numberDayOfTheWeek == 2)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + secondDayoOfTheWeek);
}

if (numberDayOfTheWeek == 3)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + thirdDayoOfTheWeek);
}

if (numberDayOfTheWeek == 4)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + fourthDayoOfTheWeek);
}

if (numberDayOfTheWeek == 5)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + fifthDayoOfTheWeek);
}

if (numberDayOfTheWeek == 6)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + sixthDayoOfTheWeek);
}

if (numberDayOfTheWeek == 7)
{
    Console.Write("Номер дня недели - " + numberDayOfTheWeek + " Название дня недели - " + seventhDayoOfTheWeek);
}