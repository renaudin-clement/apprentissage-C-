

using System;

namespace Main{

public enum Enumeration{
    ALERTE = 18,
    COURT = 19,
    VIE = 21
}

class Program
{
    static void Main(string[] args)
    {
        Enumeration charle = Enumeration.ALERTE;

        if (charle ==Enumeration.VIE){
            Console.WriteLine(Enumeration.VIE);
        }
        else if (charle ==Enumeration.ALERTE){
             Console.WriteLine(Enumeration.ALERTE);
        }
        else {
            Console.WriteLine(Enumeration.COURT);
            }

        
        
    }


}
}