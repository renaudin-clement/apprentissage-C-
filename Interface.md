using System;

namespace Main;

interface Craftable
{
    public void SelldMarchant();
    public void SelldArmure();
    public void BuildMoustache();
}

abstract class Useable
{
    public abstract void Utiliser();

    public void crier()
    {
        Console.WriteLine("hhhhhhaaaaaaa");
    }
}

class Weapon : Craftable
{
    public void SelldMarchant() => Console.WriteLine("marchand darme a vendu");
    public void SelldArmure() => Console.WriteLine("marchand a vendu une armure");
    public void BuildMoustache() => Console.WriteLine("j\'ai creer une moustache");
}

class MagicBook : Useable,Craftable 
{
    public void SelldMarchant() => Console.WriteLine("marchand de livre a vendu");
    public void SelldArmure() => Console.WriteLine("marchand de livre a vendu une armure");
    public void BuildMoustache() => Console.WriteLine("j\'ai creer une moustache de livre");

    public override  void Utiliser() => Console.WriteLine("j\'ai utiliser le livre");

}

class Program
{
    
    public static void Main(string[] args)
    {
        Weapon wep =new Weapon() ;


        wep.SelldMarchant();
        wep.SelldArmure();
        wep.BuildMoustache();

        MagicBook mb = new MagicBook();
        mb.SelldMarchant();
        mb.SelldArmure();
        mb.BuildMoustache();

        mb.crier();
        mb.Utiliser();


    }
}