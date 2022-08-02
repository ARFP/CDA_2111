// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


User u = new User()
{
    Id = 1,
    UserName = "Mike",
};

Console.WriteLine(u.ToString());
Console.WriteLine(((object)u).ToString());