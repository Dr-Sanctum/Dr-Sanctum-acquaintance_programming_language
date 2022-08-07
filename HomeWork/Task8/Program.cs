//Задание: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int x = new Random().Next(10,99);
Console.WriteLine("Дано число " + x);

int firstNumber = (x-x%10)/10;
int secondNumber = x%10;

if (firstNumber >= secondNumber)
{
    Console.WriteLine("Наибольшая цифра числа = " + firstNumber);
}
else
{
    Console.WriteLine("Наибольшая цифра числа = " + secondNumber);
}