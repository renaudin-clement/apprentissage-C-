namespace Main;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "JE_regarde_si_ca_marche";

        System.Int32 JAC =32;

        int cc =38;
        
        JAC += 1;
        System.Console.WriteLine(JAC);
        System.Console.WriteLine(cc);

        System.String lettre = "lettre je suis";
        String autrelettre = "lettre je suis seconde";

        System.Console.WriteLine(lettre);
        System.Console.WriteLine(autrelettre);

        bool lebool =true;
        if (lebool){
            System.Console.WriteLine("marche");
        }
        
        lebool =false;

        if (!lebool){
            System.Console.WriteLine("est couper");
        }
        

        float charle =1.35f;
        System.Console.WriteLine(charle);

         int number;

         number = (int)charle +3;
         System.Console.WriteLine(number);


        Console.Read();
    }
}
