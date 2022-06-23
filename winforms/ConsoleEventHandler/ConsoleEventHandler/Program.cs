// See https://aka.ms/new-console-template for more information
using ConsoleEventHandler;

Console.WriteLine("Hello, World!");

Toto toto = new Toto("Mike");

MainClass main = new MainClass(toto);

toto.Name = "Popo";
toto.Name = "Paul";

Console.ReadLine();
