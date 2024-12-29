namespace Main;

using System;

//ref = in et out
// in = juste lecture variable
// out = sortie variable
struct Disk{
    public readonly String caratere;
    public readonly int capaciter;

    public Disk(String caratere,int capaciter){
        this.caratere = caratere;
        this.capaciter = capaciter;
    }

    public override String ToString(){
        return $"le {caratere} avec pour capaciter {capaciter}" ;
    }
}



class AutreClass{

    private String nom;
    private int valeur;
    private int valeur2;

    public AutreClass(String nom,int valeur,int valeur2){
        this.nom=nom;
        this.valeur = valeur;
        this.valeur2 = valeur2;
    }

    public void setNom(String nom){
        this.nom=nom;
    }

    public void setValeur(int valeur){
        this.valeur=valeur;
    }

    public void setValeur2(int valeur2){
        this.valeur2=valeur2;
    }

    public String getNom(){
        return this.nom;
    }

    public int getValeur(){
         return this.valeur;
    }

    public int getValeur2(){
        return this.valeur2;
    }
}

class Program
{
    static void Main(string[] args)
    {

    Disk C = new Disk("haha",18);
    Console.WriteLine(C.caratere);
    
    Disk d;
    d.caratere = "aa";
    d.capaciter = 2;

    Console.WriteLine(d);
    Console.WriteLine("");

    AutreClass lautre = new AutreClass("john",17,19);
    Console.WriteLine("la class " +lautre  + " a ete creer");
    Console.WriteLine(lautre.getNom());
    Console.WriteLine(lautre.getValeur());
    Console.WriteLine(lautre.getValeur2());

}


}
