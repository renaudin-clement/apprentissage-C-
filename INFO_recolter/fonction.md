namespace Main;

using System;

//ref = in et out
// in = juste lecture variable
// out = sortie variable

class Program
{
    static void Main(string[] args)
    {
        
        System.Console.Title ="aa";
        System.Console.WriteLine("");
        System.Console.Write("");
        System.Console.Read();

        yo();
        System.Console.WriteLine(haha(3));
        
        
    }


    public static void yo(){
        Console.WriteLine("hello je suis une fonction public simple");
        int valeur =0;
        System.Console.WriteLine("yo");
        valeur = referencer(ref valeur);
        System.Console.WriteLine(valeur);
        lecture(in valeur);
        changerlavaleur(out valeur);
        lecture(in valeur);
        hello();

    }

    private static int haha(int valeur ){
        Console.WriteLine("hello je suis une fonction priver simple");
        return valeur+1;
    }

    private static int referencer(ref int valeur){
        Console.WriteLine("hello je suis une fonction priver referencer");
        return valeur+1;
    }

    private static void lecture(in int valeur2){
        System.Console.WriteLine(valeur2);
    }

    private static void changerlavaleur(out int valeur2){
        Console.WriteLine("hello je suis une fonction priver qui utiliser out pour modifier la variable directement");
        valeur2 =0;
    }

    public static void hello() => Console.WriteLine("hello je suis une fonction flecher");
}


fonction anonyme

expression anonyme
expression lambda

fonction local

methode asyncrone