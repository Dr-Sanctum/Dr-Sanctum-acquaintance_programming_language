//Задание: Определить количество цифр в числе

Console.Write("Введите число ");

int a = int.Parse(Console.ReadLine());

int result = a;
int i = 1;

while (result >= 10)
{
    result = result/10;
    
    i++;
}
Console.Write("В числе " + a + " количество цифр = " + i);
