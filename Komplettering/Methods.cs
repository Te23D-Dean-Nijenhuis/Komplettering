using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Komplettering;

public class Methods
{
    public static int TryParse_MultiChoice(int choiceCount, int choice) //En metod som används när man stöter på ett Multiple choice.
    {
        bool success = false; //bool för tryparse.
        while (!success) //bryts endast när tyrparsen lyckas.
        {
            success = int.TryParse(Console.ReadLine(), out choice);
            if (!success) //ilsket meddelande när man larvar sig (du skrev som en string och inte en int)
            {
                Console.WriteLine("Sluta larva dig! Skriv en SIFFRA, inte en STRING!!!");
                Loading();
                Thread.Sleep(2000);
                UserChoiceError(3);
            }
            else if (choice < 1 || choice > choiceCount) //om parsen lyckas fast det är utom range.
            {
                Console.WriteLine("ÄR DET VERKLIGEN ETT GILTIGT ALTERNATIV?!?!?!");
                Loading();
                UserChoiceError(3);
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

    public static void UserChoiceError(int errorLines) //när användaren gör fel med input så tar denna bort vad som skrivits. int som kastas in är hur många lines som ska bort.
    {
        Console.SetCursorPosition(0, Console.CursorTop - errorLines); //cursor hoppar upp erroLines antal steg.
        for (int i = 0; i < errorLines + 1; i++)  //error lines + 1 rad blir blanksteg.
        {
            Console.WriteLine(new string(' ', Console.WindowWidth));   //hela raden blir blanksteg.
        }
        Console.SetCursorPosition(0, Console.CursorTop - (errorLines + 1)); //cursor hoppar upp 3 steg.
    }
}

