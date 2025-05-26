using System.Data.Common;
using System.Security;
using System.Security.Principal;
using Komplettering;
// SHIFT + ALT + F = FORMATERING

//för Beskrivning av metoder: Se där dem är skrivna Skriver ej upprepningar hela tiden.

bool success = false;

int choiceCount; //måste vara deklarerad innan.
int choice = 0;
int errorLines = 0;

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
}
else if (choice == 2)
{
    Console.WriteLine("Bra! Riktigt smart val.");
    Thread.Sleep(2000);
    Console.WriteLine("Det var så uppfriskande att du nu kommer ihåg dina stats och personuppgifter.");
    Methods.Loading();
}

Console.Clear();
Console.WriteLine("Vad heter du?:");
Character user = new Character(); //skapar en instans av character "user" 

while (user.name.Length > 14 || user.name == "") //loopen fortsätter så läge du skriver ett namn längre än 14 bokstäver, även ifall namn är tomt vilket det är i början.
{
    user.name = Console.ReadLine(); //user namn blir lika med user input.
    Methods.Loading();
    if (user.name.Length > 14)
    {
        Console.WriteLine("Oj, är du säker på att det är ett riktigt namn, det är ganska långt.");
        Thread.Sleep(4000);
        Methods.UserChoiceError(3);
    }
}
Console.Clear();

while (!success) //vanlig tryparse loop
{
    Console.WriteLine($"Okej {user.name}, hur gammal är du då?:");
    Thread.Sleep(2000);

    success = int.TryParse(Console.ReadLine(), out user.age); //din ålder blir vad du skriver in.
    Methods.Loading();


    if (user.age < 18) //om du är yngre än 18 
    {
        Console.WriteLine($"Sakta i backarna där, {user.name}. Man måste vara över 18 för att konsumera alkohol.");
        Thread.Sleep(4000);
        Console.WriteLine("Ska du skaffa Fake legitimation?");
        Thread.Sleep(2000);
        Console.WriteLine("1. Nej, det är ju olagligt!");
        Console.WriteLine("2. Ja, jag är tuffing");

        choice = Methods.TryParse_MultiChoice(choiceCount = 2, choice);
        Console.Clear();
        if (choice == 1)
        {
            Console.WriteLine("Du blir tagen av snuten och dömd till dödsstraff");
            Thread.Sleep(2000);
            Console.WriteLine("Som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
            Thread.Sleep(5000);
            Console.WriteLine("Som du kanske vet så är detta inte bra.");
            Thread.Sleep(2000);
            int[] array = [2]; // en crash med flit.
            int crashOut = array[2]; //en crash med flit.
        }
        else if (choice == 2)
        {
            Console.WriteLine($"Du kan nu göra allting som en 18-åring kan.");
            Thread.Sleep(2000);
            Console.WriteLine("Tyvär så kostade det 500 kr, så du är nu pank. Nu heter du även McLovin.");
            user.name = "McLovin";
            user.age = 18;
            user.cash -= 500;
            Thread.Sleep(4000);
        }
        Console.Clear();
    }
    else if (user.age > 99) // du är för gammal
    {
        Console.WriteLine("du dör av ålder");
        Methods.Loading();
        Console.WriteLine("som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
        Thread.Sleep(5000);
        Console.WriteLine("som du kanske vet så är detta inte bra.");
        Thread.Sleep(2000);
        int[] array = [2]; // en crash med flit.
        int crashOut = array[2]; //en crash med flit.
    }
    else //du har en bra ålder. 18 - 99
    {
        Console.WriteLine($"Schysst {user.name}, du är {user.age} år gammal.");
        Thread.Sleep(3000);
    }
}
Console.Clear();
Methods.Loading();
Console.WriteLine("Hur ofta tränar du? (detta påverkar din styrka):");
Console.WriteLine("1. Vad är träning?"); // du dör för att dina muskler aldrig har upplevt någonting (inklusive ditt hjärta)
Console.WriteLine("2. Jag har hört talas om det."); //du fär låg styrka
Console.WriteLine("3. ca 1 gång i veckan."); //normal styrka
Console.WriteLine("4. ca 3 gånger i veckan."); //perfekt styrka
Console.WriteLine("5. varje dag eller flera gånger varje dag."); // du dör eftersom du har tränta sönder dig själv.
Methods.TryParse_MultiChoice(choiceCount = 5, choice);

Console.Clear();

if (choice == 1)
{
    Console.WriteLine("Du dör pågrund av att du är för svag");
    Thread.Sleep(2000);
    Console.WriteLine("Som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
    Thread.Sleep(5000);
    Console.WriteLine("Som du kanske vet så är detta inte bra.");
    Thread.Sleep(2000);
    int[] array = [2]; // en crash med flit.
    int crashOut = array[2]; //en crash med flit.
} else if (choice == 2)
{
    
}




Console.ReadLine();