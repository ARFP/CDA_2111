
// See https://aka.ms/new-console-template for more information
using Dp_Interfaces;
using Dp_intro.Models;

Console.WriteLine("Hello, World!");

Batiment batiment = new Batiment(100);
BienImmobilier bien = new BienImmobilier(150, 500);

MyClass myClass = new MyClass();

myClass.AfficherBatiment(batiment);
myClass.AfficherBatiment(bien);

Console.ReadLine();