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
Methods.RemoveLines(1);
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
    Thread.Sleep(1000);
    Methods.Loading();
    Methods.RemoveLines(1);
    Thread.Sleep(1000);  //min mamma tyckte det gick för snabbt.
}

Console.Clear();
Console.WriteLine("Vad heter du?:");
Character user = new Character(); //skapar en instans av character "user" 

while (user.name.Length > 14 || user.name == "") //loopen fortsätter så läge du skriver ett namn längre än 14 bokstäver, även ifall namn är tomt vilket det är i början.
{
    user.name = Console.ReadLine(); //user namn blir lika med user input.
    Methods.Loading();
    Methods.RemoveLines(1);
    if (user.name.Length > 14)
    {
        Console.WriteLine("Oj, är du säker på att det är ett riktigt namn, det är ganska långt.");
        Thread.Sleep(4000);
        Methods.RemoveLines(3);
    }
}
Console.Clear();

while (!success) //vanlig tryparse loop
{
    Console.WriteLine($"Okej {user.name}, hur gammal är du då?:");
    Thread.Sleep(2000);

    success = int.TryParse(Console.ReadLine(), out user.age); //din ålder blir vad du skriver in.
    Methods.Loading();
    Methods.RemoveLines(1);


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
            Thread.Sleep(3000);
            Console.WriteLine("som tur så har pengar ingen funktion eftersom programerings tiden är kort.");
            user.name = "McLovin"; //ditt namn är nu McLovin. 
            user.age = 18;         //du är 18 år.
            user.cash -= 500;      //500 riksdaler försvinner.
            Thread.Sleep(4000);
        }
        Console.Clear();
    }
    else if (user.age > 99) // du är för gammal
    {
        Console.WriteLine("du dör av ålder");
        Methods.Loading();
        Methods.RemoveLines(1);
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
Methods.RemoveLines(1);
Console.WriteLine("Hur ofta tränar du? (detta påverkar din styrka):");
Console.WriteLine("1. Vad är träning?"); // du dör för att dina muskler aldrig har upplevt någonting (inklusive ditt hjärta)
Console.WriteLine("2. Jag har hört talas om det."); //du fär låg styrka
Console.WriteLine("3. ca 1 gång i veckan."); //normal styrka
Console.WriteLine("4. ca 3 gånger i veckan."); //perfekt styrka
Console.WriteLine("5. varje dag eller flera gånger varje dag."); // du dör eftersom du har tränta sönder dig själv.
choice = Methods.TryParse_MultiChoice(choiceCount = 5, choice);

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
}
else if (choice == 2)
{
    user.strength = 10;
}
else if (choice == 3)
{
    user.strength = 50;
}
else if (choice == 4)
{
    user.strength = 100;
}
else if (choice == 5)
{
    Console.WriteLine("Du dör pågrund av att alla dina muskler har gått sönder och för att du tar steroider.");
    Thread.Sleep(4000);
    Console.WriteLine("Som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
    Thread.Sleep(5000);
    Console.WriteLine("Som du kanske vet så är detta inte bra.");
    Thread.Sleep(2000);
    int[] array = [2]; // en crash med flit.
    int crashOut = array[2]; //en crash med flit.
}
Console.Clear();

Methods.Loading();
Methods.RemoveLines(1);

Methods.Stats_2(user);
Methods.Loading();
Methods.RemoveLines(1);
Console.WriteLine($"{user.name}, Såhär ser det ut när när dina stats visas upp.");
Methods.Loading();
Methods.RemoveLines(1);
Console.WriteLine("Tryck på enter när du är redo att gå vidare.");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Målet med detta spel är att försöka ta sig hem utan att dö");
Methods.Loading();
Methods.RemoveLines(1);
Console.WriteLine("Tryck på enter när du är redo att gå vidar.");
Console.ReadLine();
Console.Clear();

Methods.Loading();
Methods.RemoveLines(1);
Console.WriteLine($"På vägen hem hittar du en cool kniv. Väljer du att ta upp den?");
Methods.Loading();
Methods.RemoveLines(1);
Methods.RemoveLines(1);
Console.WriteLine($"1. Ja");
Console.WriteLine($"2. Nej");
choice = Methods.TryParse_MultiChoice(choiceCount = 2, choice);
Methods.Loading();
Methods.RemoveLines(1);
Console.Clear();

if (choice == 1)
{
    Console.WriteLine("Smart! Man vet aldrig när man kan behöva en Kniv");
    user.inventory[0] = (user.inventory[0].item, 1);  //kniv count = 1.
    Thread.Sleep(2000);
}
else if (choice == 2)
{
    Console.WriteLine("Oj, tänk om du någongång behöver en kniv.");
    Thread.Sleep(2000);
    Methods.Loading();
    Methods.RemoveLines(1);
    Methods.RemoveLines(1);
    Console.WriteLine($"{user.name}, är du verkligen säker på att du inte vill ha kniven?");
    Console.WriteLine("1. okej jag tar den");
    Console.WriteLine("2. Nej jag avstår");
    choice = Methods.TryParse_MultiChoice(choiceCount = 2, choice);
    Methods.Loading();
    Methods.RemoveLines(1);
    Console.Clear();

    if (choice == 1) // du får en till chans du dör om du inte tar upp kniven.
    {
        Console.WriteLine("Smart! Man vet aldrig när man kan behöva en Kniv");
        user.inventory[0] = (user.inventory[0].item, 1);  //kniv count = 1.
        Thread.Sleep(2000);
    }
    else if (choice == 2) // du väljer att inte ta upp kniven.
    {
        Console.WriteLine("oj nu har du ingen kniv, vi får hoppas på att det inte leder till någontin dåligt...");
        Thread.Sleep(5000);
    }
}
Console.Clear();

Methods.Loading();
Methods.RemoveLines(1);

Console.WriteLine("Du stöter på en ond man utanför ditt hus. Han har dina nycklar");
Thread.Sleep(3000);
Console.WriteLine("För att komma in i ditt hus måste du besegra honom.");
Thread.Sleep(3000);
Methods.Loading();

Console.WriteLine("väljer du att fajta honom?");
Console.WriteLine("1. Ja jag måste ju.");
Console.WriteLine("2. Nej jag vill förlora spelet.");

choice = Methods.TryParse_MultiChoice(choiceCount = 2, choice);

Console.Clear();
if (choice == 1) //du har valt att fajta honom. (för detta kommer kniv och styrka >= 50 behövas.)
{
    if (user.inventory[0].count > 0 && user.strength >= 50) //om du har kniv och är starkare ämn 50
    {
        Console.WriteLine("Grattis du vann spelet, eftersom du var tillräckligt stark och hade en kniv.");
        Methods.Loading();
        Console.WriteLine("tryck enter för att stänga av.");
    }
    else // du förlorar fajten.
    {
        Console.WriteLine("du är antingen för svag eller har ingen kniv, programmeraren hade inte tid att skriva för båda scenarion.");
        Thread.Sleep(4000);
        Console.WriteLine("Som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
        Thread.Sleep(5000);
        Console.WriteLine("Som du kanske vet så är detta inte bra.");
        Thread.Sleep(2000);
        int[] array = [2]; // en crash med flit.
        int crashOut = array[2]; //en crash med flit.
    }
}
else if (choice == 2)
{
    Console.WriteLine("Nästa gång så fajtar du, förstår du?");
    Thread.Sleep(4000);
    Console.WriteLine("Som straff så kommer programmet försöka att plocka ett värde ur en array från ett index som inte finns.");
    Thread.Sleep(5000);
    Console.WriteLine("Som du kanske vet så är detta inte bra.");
    Thread.Sleep(2000);
    int[] array = [2]; // en crash med flit.
    int crashOut = array[2]; //en crash med flit.

}




Console.ReadLine();