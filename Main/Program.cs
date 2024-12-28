


using System;

namespace Main;

abstract class Consumable
{
    
    public void SellToMarchand() => Console.WriteLine("vendu !");

    public abstract void rire();

}

class MagicLivre : Consumable
{
    public override void rire()
    {
         Console.WriteLine("litlitlit ! \n");
    }
}

class Ane : Consumable
{
    public override void rire()
    {
         Console.WriteLine("hyhyhyhy ! \n");
    }
}



class Program
{

    
    static void Main(string[] args)
    {
        MagicLivre x = new MagicLivre();
        Console.WriteLine("MagicLivre !");
        x.SellToMarchand();
        x.rire();

        Ane l = new Ane();
        Console.WriteLine("Ane !");
        l.SellToMarchand();
        l.rire();
        

    }
}
