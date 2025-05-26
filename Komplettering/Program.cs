using System.Security;
using Komplettering;
// SHIFT + ALT + F = FORMATERING

//för Beskrivning av metoder: Se där dem är skrivna Skriver ej upprepningar hela tiden.

int choiceCount; //måste vara deklarerad innan.
int choice = 0;

Console.WriteLine("Du vaknar upp på en lergi stig med en kraftig bakfylla.\nSom tur så är du smart och har vätske ersättning i din väska.\n");
Methods.Loading(); 
Thread.Sleep(2000); // 2 sekunder vänta
Console.WriteLine("Väljer du att dricka Vätskeersättningen? \nSkriv det alternativ som du väljer och tryck sedan på enter.");
Console.WriteLine("1. Nej, usch.");
Console.WriteLine("2. Ja, Det skulle vara smart.");
choice = Methods.TryParse_MultiChoice(choiceCount = 2, choice);

Console.Clear(); // tömmer skärmen.
if (choice == 1) // du dricker inte vätske ersättning.
{   
    Console.WriteLine("Du dör på grun av vätske och mineral brist.");
    Thread.Sleep(2000);
    Console.WriteLine("som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
    Thread.Sleep(5000);
    Console.WriteLine("som du kanske vet så är detta inte bra.");
    Thread.Sleep(2000);
    int[] array = [2]; // en crash med flit.
    int crashOut = array[2]; //en crash med flit.
} else if (choice == 2)
{
    Console.WriteLine("Bra! Riktigt smart val.");
    Thread.Sleep(2000);
    Console.WriteLine("Det var så uppfriskande att du nu kommer ihåg dina stats och personuppgifter.");
    Methods.Loading();
}

Console.Clear();
Console.WriteLine("Vad heter du?:");
Character user = new Character();

user.name = Console.ReadLine();


Console.ReadLine();