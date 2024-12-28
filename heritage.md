

using System;

namespace Main;

//parent
class Widge
    {
        //ne pas oublier dutiliser protected mais elle est que pour les classe deriver pas pour elle meme
        public String Titre {get;set;} ="default" ;

        public Widge(String title) => this.Titre = title ;

        //VIRTUAL  autorise la derivation en override en gros ca permet de dire tu peux override cette methode
        public virtual void Test() => Console.WriteLine("Widge test");
    }

//boutton enfant de Widge
class Boutton : Widge
    {
        public int Color {get;set;}  =0;

        public Boutton(String title,int Color) : base(title)
        {
            this.Color = Color ;
        }

        public override void Test() => Console.WriteLine("Boutton test");
    }

class Program
{

    
    static void Main(string[] args)
    {
       Widge a = new Widge("programme C#");
       Console.WriteLine(a.Titre);
       a.Test();

       Boutton but = new Boutton("progatron",18);
       Console.WriteLine(but.Titre);
       Console.WriteLine(but.Color);
       but.Test();
    }
}


/*
sealed class ClassFini{
    public String Titre {get;set;} ="default" ;

        public Widge(String title) => this.Titre = title ;
}
*/