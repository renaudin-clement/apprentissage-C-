using System;

namespace Main;

abstract class Figther
{
    public abstract void Fight();

    virtual public void Degat()
    {
        Console.WriteLine("-10 pv");
    }

}

class Humain:Figther
{
    public override void Fight()
    {
        
        Console.WriteLine("pour l'Alliance");
    }

    public override void Degat()
    {   
        //base.Degat(); possible si vous voulez rajouter le code precedent
        Console.WriteLine(" -5 pv");
    }

}

class Orc :Figther
{
    public override void Fight()
    {
        Console.WriteLine("pour l'ordre");
    }

   
    
}

class Program
{
    
    public static void Main(string[] args)
    {

        
        Humain H1 = new Humain();
        Humain H2 = new Humain();

        Humain[] ArmyHumain = new Humain[] {H1,H2};
        Console.WriteLine("armer de Humain");
        foreach (var human in ArmyHumain)
            {
            human.Fight();
            human.Degat();
            }

        Orc O1 = new Orc();
        Orc O2 = new Orc();


        Orc[] armerorck = new Orc[] {O1,O2};
        Console.WriteLine("");
        Console.WriteLine("armer de ORC");
        foreach (var orck in armerorck)
            {
            orck.Fight();
            orck.Degat();
            }


        Figther[] combatant = new Figther[] {H1,H2,O1,O2};

        Console.WriteLine("");
        Console.WriteLine("armer de combatant");
        foreach (var combatante in combatant)
            {
            combatante.Fight();
            combatante.Degat();
            }


    }
}