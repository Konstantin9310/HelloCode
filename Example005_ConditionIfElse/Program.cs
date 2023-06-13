Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Ксюша" )
{
    Console.WriteLine("Привет, родная");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}