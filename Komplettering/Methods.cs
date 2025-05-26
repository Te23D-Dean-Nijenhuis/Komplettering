using System;

namespace Komplettering;

public class Metoder
{
    public static int TryParse_2Choice ()
    {
        bool success = false;
        int choice = 0; // Variabeln måste ha ett värde annars spökar programmet då den är rädd att en null värde ska retuneras.
        while(!success)
        {
            success = int.TryParse(Console.ReadLine(), out choice);
            if (!success)
            {
                
            }
        }
        return choice;
    }

    public static void Loading
}
