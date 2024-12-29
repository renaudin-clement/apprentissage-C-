using System;
using System.Diagnostics;

namespace Main;

class Program
{
    //avant execution Debug.Assert() , Trace.Assert()
    
    //utilisation assert debug pour securiser de possible erreur
    //marche sur le projet brut mais pas en realese
    public static void valueurinfa0(int number){
        Debug.Assert(number < 0);
        Console.WriteLine("cool");
    }

    public static void valueurinfaV2(int number){
        Debug.Assert(number < 0,"number < 0","le nombre dois etre inferieur a 0");
        Console.WriteLine("cool");
    }


    //utilisation assert debug pour securiser de possible erreur
    //marche sur le projet brut et aussi en realese
    public static void valueurpositif(int number){
        Trace.Assert(number >= 0);
        Console.WriteLine("cool");
    }

        public static void valueurpositifV2(int number){
        Trace.Assert(number >= 0,"erreur pour number >= 0 regarde");
        Console.WriteLine("cool");
    }




    public static void Main(string[] args)
    {

    //interieur du code 
    Console.WriteLine("--------");
    valueurinfa0(-15);
    Console.WriteLine("");
    valueurinfa0(40);
    Console.WriteLine("--------");

    Console.WriteLine("");

    Console.WriteLine("--------");
    valueurpositif(40);
    Console.WriteLine("");
    valueurpositif(-15);
    Console.WriteLine("--------");

    Console.WriteLine("");

    Console.WriteLine("--------");
    valueurinfaV2(-15);
    Console.WriteLine("");
    valueurinfaV2(40);
    Console.WriteLine("--------");

    Console.WriteLine("");
        
    Console.WriteLine("--------");
    valueurpositifV2(40);
    Console.WriteLine("");
    valueurpositifV2(-15);
    Console.WriteLine("--------");


    //a lexecution du code 
    }
}
