Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "светлана")
{
    Console.WriteLine("Ура, это же Света!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}