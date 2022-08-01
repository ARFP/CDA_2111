// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello!");

Console.WriteLine("Veuillez entrer une date :");
string? userDate = Console.ReadLine();

CultureInfo frenchFormat = new CultureInfo("fr-FR");

try
{
    DateTime date = DateTime.Parse(userDate, frenchFormat);

    Console.WriteLine($"Votre date est : {date.ToString()}");
}
catch (ArgumentNullException e)
{
    Console.WriteLine("la date ne peut être vide");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}


