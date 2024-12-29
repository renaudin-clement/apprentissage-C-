using System;


namespace Main;

class Program
{
   
    public static void Main(string[] args)
    {
    int number = 0;
    
    try
    {
        Console.WriteLine("Saissir un entier: ");
        number =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"le nombre saissie est {number}");
    }
    
    catch(FormatException e)
    {
        Console.WriteLine("erreur format");
        Console.WriteLine(e);
    }

    catch(Exception e)
    {
        Console.WriteLine("erreur general");
        Console.WriteLine(e);
        
    }


    finally
    {
        Console.WriteLine($"le nombre saissie est {number}");
    }

    

    }
}

