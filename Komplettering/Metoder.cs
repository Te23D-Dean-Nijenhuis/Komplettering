using System;

namespace Komplettering;

public class Methods
{
    public static int TryParse_2Choice()
    {
        bool success = false;
        int choice = 0; // Variabeln måste ha ett värde annars spökar programmet då den är rädd att en null värde ska retuneras.
        while (!success)
        {
            success = int.TryParse(Console.ReadLine(), out choice);
            if (!success)
            {

            }
        }
        return choice;
    }

    public static void Loading()
    {
        for (int i = 0; i < 5; i++) //loop som skriver ut 5 punkter som laddar.
        {
            Console.Write(".");
            Thread.Sleep(500);   //programmet "sover" i 500 ms
        }
    }
}
