// See https://aka.ms/new-console-template for more information
using Dp_intro.Models;

Console.WriteLine("Biens immobiliers !");


List<string> equipementBureau = new List<string>
{
    "chaises x3", "canapé", "bureau", "lampe halogène", "évier", "toilettes"
};

List<BienImmobilier> liste = new List<BienImmobilier>()
{
    new Bureau(120, 1200, equipementBureau),
    new CabinetMedical(90, 900, true),
    new LocalCommercial(1500, 9800),
    new LocalCommercial(300, 2100),
    new CabinetMedical(70, 1500, false),
    new CabinetMedical(110, 2100, true)
};