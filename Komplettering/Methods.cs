using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Komplettering;

public class Methods
{
    public static int TryParse_MultiChoice(int choiceCount, int choice) //En metod som används när man stöter på ett Multiple choice. När man lägger in ett värde på choice count så blir det antal möjliga val.
    {
        bool success = false; //bool för tryparse.
        while (!success) //bryts endast när tyrparsen lyckas.
        {
            success = int.TryParse(Console.ReadLine(), out choice);
            if (!success) //ilsket meddelande när man larvar sig (du skrev som en string som inte kan konverteras till int)
            {
                Console.WriteLine("Sluta larva dig! Skriv en SIFFRA, inte en STRING!!!");
                Loading();
                Thread.Sleep(2000);
                RemoveLines(3);
            }
            else if (choice < 1 || choice > choiceCount) //om parsen lyckas fast det är utom range.
            {
                Console.WriteLine("ÄR DET VERKLIGEN ETT GILTIGT ALTERNATIV?!?!?!");
                Loading();
                RemoveLines(3);
                success = false; //loopen ska börja om även fast parse lyckades.
            }
        }
        Loading();
        return choice;
    }

    public static void Loading()  //Metod som gör en kort loading grej.
    {
        for (int i = 0; i < 5; i++) //loop som skriver ut 5 punkter som laddar.
        {
            Console.Write(".");
            Thread.Sleep(500);   //programmet "sover" i 500 ms
        }
        Console.WriteLine();
    }

    public static void RemoveLines(int errorLines) //T.ex när användaren gör fel med input så tar denna bort vad som skrivits. int som kastas in är hur många lines som ska bort.
    {
        Console.SetCursorPosition(0, Console.CursorTop - errorLines); //cursor hoppar upp erroLines antal steg.
        for (int i = 0; i < errorLines + 1; i++)  //error lines + 1 rad blir blanksteg.
        {
            Console.WriteLine(new string(' ', Console.WindowWidth));   //hela raden blir blanksteg.
        }
        Console.SetCursorPosition(0, Console.CursorTop - (errorLines + 1)); //cursor hoppar upp 3 steg.
    }

    public static void Stats_1(Character user) //skriver ut alla stats, körs lite då och då.
    {
        Console.WriteLine($"Pågrund av dina vanor och val i livet så har du följande stats: \nNamn: {user.name}.\nÅlder: {user.age}.\nStyrka: {user.strength}.\nCash-Money: {user.cash}.");
    }

    public static void Stats_2 (Character user)  // en annan version av metoden ovan, samma funktion men annan stil.
    {
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine(new string('-', Console.WindowWidth/3));  /// skriver ut en serie av "-" som är 1/3 bredden av konsolen.
        Console.WriteLine($"Namn: {user.name}.");
        Console.WriteLine($"Ålder: {user.age}.");
        Console.WriteLine($"Stryka: {user.strength}.");
        Console.WriteLine($"Cash-money: {user.cash}.");
        Console.WriteLine(new string('-', Console.WindowWidth/3));  /// skriver ut en serie av "-" som är 1/3 bredden av konsolen.
    }   
}