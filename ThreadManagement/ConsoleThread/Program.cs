// See https://aka.ms/new-console-template for more information
using ConsoleThread;


/*
Proposez une solution pour permettre aux classes 
ResultTextWriter et ResultAlternateTextWriter (toutes 2 dans le fichier ResultTextWriter.cs)
d'afficher la valeur de "SquareCalculator.number".

/!\ "SquareCalculator.number" doit rester "private" et sans accesseur public !
/!\ La signature de "SquareCalculator.SquareIt()" ne doit pas être modifiée !
/!\ l'interface "IWriter" et toutes les classes dépendantes ne peuvent pas être modifiées !
*/

Console.WriteLine("Hello, World!");

IWriter writer = new ResultTextWriter();
DisplayNumber callback = new DisplayNumber(writer.WriteResult);

IToto toto = new TotoDisplay();
DisplayNumber calltoto = new DisplayNumber(toto.Display);


//DisplayNumber calltest = new DisplayNumber(test);



Thread th = new Thread(() =>
{
    SquareCalculator calc = new SquareCalculator(2, callback);

    calc.SquareIt();

    Thread.Sleep(2000);

    calc.callback = calltoto;

    calc.SquareIt();
});


th.Start();

Console.WriteLine("end");