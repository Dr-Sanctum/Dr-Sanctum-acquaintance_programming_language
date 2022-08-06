Console.Write("Введите имя пользователя: ");
string UserName = Console.ReadLine();
if (UserName.ToLower() == "маша")
{
    Console.Write("Привет СУПЕРМАША");
}
else
{
    Console.Write("Привет " + UserName);
}
