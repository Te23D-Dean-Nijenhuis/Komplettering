using System;

namespace Komplettering;

public class Character // du
{
    public string name = ""; // ditt namn
    public int age; //din ålder
    public float strenght; // din styrka
    public List<(int id, int count)> inventory = []; // ditt inventory, int representerar ett id till en annan lista som innehåller items. och count är som det låter.
    public float cash = 500;
}
