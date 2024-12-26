namespace Main;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "JE_regarde_si_ca_marche";

        String JAC ="jack";

        bool j = false;
        List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };

        while(!j){

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }
        System.Console.WriteLine($"je suis {JAC}");
        j = true;
        }

        
        foreach (int element in fibNumbers)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine("");
        int n = 0;
        do
        {
            Console.WriteLine(n);
            n++;
        } while (n < 5);

        Console.Read();
    }
}
