// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");


string date = "dd/MM/yyyy";
Console.WriteLine("veuillez entrer une date au format : " + date );
string inputDate = Console.ReadLine();

try
{
    DateTime dt = DateTime.ParseExact(inputDate, date, CultureInfo.InvariantCulture);
    Console.WriteLine("la date est valide : " + dt.ToShortDateString() + " et " + dt.ToLongDateString());
}
catch (ArgumentNullException e)
{
    Console.WriteLine("la date ne peut être vide");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}


