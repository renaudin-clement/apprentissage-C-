

using System;

namespace Main;

class Proprieter{
    // posibiliter davoir un get et un set en utilisant Title et pas _title
    private String _title;

    public String Title
    {
        get{
            return _title;
        }

        set{
            _title = value; //value est un mot clef
        }
        //init
    }

    public Proprieter(String _title) => this._title = _title;

}

class Proprieter2{
    // posibiliter davoir un get mais pas un set en utilisant Title et pas _title
    private String _title2;

    public String Title2
    {
        get{
            return _title2;
        }
        //init
    }

    public Proprieter2(String _title2) => this._title2 = _title2;

}

class Proprieter3{
    // posibiliter davoir un get mais pas un set en utilisant Title et pas _title
    private String _title3;

    public String Title3
    {
        get{
            return _title3;
        }

        set{
            if(value != "haha"){
            this._title3 = value  ;
            }
            else{this._title3 = "nonosquare"  ;}
        }
        //init
    }

    public Proprieter3(String _title3) => this._title3 = _title3;

}

/*
class Proprieter_simplifier{
    // posibiliter davoir un get et un set en utilisant Title et pas _title
    private String _title;

    public String Title
    {
        get => return _title;
        

        set => this._title3 = value  ;
    }
    public Proprieter3(String _title3) => this._title3 = _title3;

}
*/
class Proprieter_autre{
    
    public String Title{get;set;}

    public Proprieter3(String _title3) => this._title3 = _title3;

}

class Program
{

    // convention pour les attribut _nomAttribue
    static void Main(string[] args)
    {
        Proprieter G = new Proprieter("toto");
        Proprieter2 G2 = new Proprieter2("titi");

        Proprieter3 G3 = new Proprieter3("haha");


        Console.WriteLine(G.Title);

        G.Title = "yayoyi";
        Console.WriteLine(G.Title);

        //G2.Title2 = "yayoyi";
        Console.WriteLine(G2.Title2);



        Console.WriteLine(G3.Title3);
        G3.Title3 = "hoho";
        Console.WriteLine(G3.Title3);
        G3.Title3 = "haha";
        Console.WriteLine(G3.Title3);


    }
}
