using System;
using System.Security.Cryptography.X509Certificates;

namespace Komplettering;

public class Character // du
{
    public string name = ""; // ditt namn
    public int age; //din ålder
    public float strength; // din styrka
    public List<(string item, int count)> inventory = // ditt inventory, string är vilket item. och count är som det låter.
    [
        ("Kniv", 0), //index
        ("Nycklar", 0),
        ("Protein bar", 5),
        ("Steroider", 3)
    ]; 
    public float cash = 500;
}
