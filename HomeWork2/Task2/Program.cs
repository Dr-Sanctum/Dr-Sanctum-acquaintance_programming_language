//Задание: По двум заданным числам проверять является ли одно квадратом другого (с помощью функции)

string checkSqare(int firstNumber, int secondNumber)
{
if (firstNumber == secondNumber*secondNumber)
{
    return "Первое число является квадратом второго";
}
else 
{
    return "Первое число не является квадратом второго";}
}


Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите первое число ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine( checkSqare(a, b));

