using System;

namespace Main;

class Program
{
    
    public static void Main(string[] args)
    {

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("--------------Tableau----------------------------");
Console.WriteLine("------------------------------------------------------");


Console.WriteLine("C# utilisation de Length");
Console.WriteLine("tableau multidimensionnelle [,] ou [,,] ou [,,,,,,,,,,,,,,]");
Console.WriteLine("tableau de tableau [][] ");
Console.WriteLine("C# tableau et de taille fix !!!");


Console.WriteLine("C# utilisation de Length");
Console.WriteLine("C# utilisation de Length");


    int[] tableau_entier = new int[5]; // chaque valeur est a 0 et de taille 5
    int[] tableau_entier2 = new int[] {1,2,32}; // a une taille de 3 car trois element on ete instancier
    int[] tableau_entier3 = {15,22,25}; // instanciation rapide

        Console.WriteLine("");

        Console.WriteLine(tableau_entier);
        Console.WriteLine(tableau_entier2);
        Console.WriteLine(tableau_entier3);

        Console.WriteLine("");

        Console.WriteLine(tableau_entier3[2]);
        tableau_entier3[2] = 2;
        Console.WriteLine(tableau_entier3[2]);

        Console.WriteLine("");

        foreach(var element in tableau_entier3){
            Console.Write(element);
        }
        
        Console.WriteLine("");
        for(int i =0; i<tableau_entier3.Length;i++)
        {
            tableau_entier3[i] = 0 ;
        }

        foreach(var element in tableau_entier3){
            Console.Write(element);
        }
        
        Console.WriteLine("");




Console.WriteLine("------------------------------------------------------");
Console.WriteLine("--------------IMPORTANT-------------------------------");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("tableau a 2 dimension");
Console.WriteLine("en C# le int[,]");
Console.WriteLine("C# utilisation de GetUpperBound(x)");

        //tableau a 2 dimension
        // en C# le int[,]

        int[,] tableau_dimension2 = new int[2,2];
        Console.WriteLine(tableau_dimension2);

        int[,] tableau_dimension21 = 
        {
             {1,2} , {3,4} 
        };

        Console.WriteLine(tableau_dimension21);

        
        Console.WriteLine("");

        for(int i =0; i <= tableau_dimension21.GetUpperBound(0);i++){
            Console.WriteLine("");
            for(int j =0; j <= tableau_dimension21.GetUpperBound(1); j++)
                {
                    Console.Write(tableau_dimension21[i,j]);
                }
        }

        Console.WriteLine("");
        Console.WriteLine("");

        int compteur =0;
        foreach (var element in tableau_dimension21)
        {
            if (compteur == 2)
            {
                Console.WriteLine("");
                compteur =0;
            }
            Console.Write(element);
            compteur++;
        }

        Console.WriteLine("");
        


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("--------------IMPORTANT 2 ----------------------------");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("C# tableau int[][]");
Console.WriteLine("C# utilisation de Length");


    int[][] Tab = new int[2][];
        
    Tab[0] = new int[] {1,2,3};
    Tab[1] = new int[] {4,5,6,7};

    for (int i =0; i<Tab.Length; i++ ){
        Console.WriteLine("");
        for (int j =0; j<Tab[i].Length; j++ ){
            Console.Write(Tab[i][j]);
        }
    }
    
    Console.WriteLine("");

    
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("--------------   Annexe   ----------------------------");
Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Array.Clear(array)");
Console.WriteLine("Array.Reverse(array)");
Console.WriteLine("Array.Fill(array, valeur)");

Console.WriteLine("Array.IndexOf(array, valeur)");
Console.WriteLine("Array.GetValue(array, valeur)");

Console.WriteLine("Array.Sort(array)");
Console.WriteLine("Array.Copy(array1,arraydirection,nombrejusquou)");



    }
}
