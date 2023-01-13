using MojeKlasy1.przyklady_klas;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!"); 
        Osoba osoba = new Osoba("Anna", "Kot", new DateTime(1989, 9, 27), 'k');
        Console.WriteLine(osoba.Wypisz());
        Console.WriteLine("Ilość przezytych dni: " + osoba.IleDni() + "\n");

        Osoba janek = new Osoba("Jan", "Kowalski", new DateTime(2023,1,13), 'm');
        Console.WriteLine(janek.Wypisz());
        Console.WriteLine("Ilość przezytych dni: " + janek.IleDni() + "\n");*/

        //zadanie: gry
        gry CounterStrike = new gry("Counter Strike", "Valve", new DateTime(2005, 8, 16));
        Console.WriteLine(CounterStrike.Wypisz2());
        Console.WriteLine("Ilość dni od pierwszego uruchomienia: " + CounterStrike.IleDni2());

        gry Fortnite = new gry("Fortnite", "Epic Games", new DateTime(2018, 4, 28));
        Console.WriteLine(Fortnite.Wypisz2());
        Console.WriteLine("Ilość dni od pierwszego uruchomienia: " + Fortnite.IleDni2());

        gry AssasinCreed = new gry("Assasic Creed", "Ubisoft", new DateTime(2015,2,3));
        Console.WriteLine(AssasinCreed.Wypisz2());
        Console.WriteLine("Ilość dni od pierwszego uruchomienia: " + AssasinCreed.IleDni2());

    }
}