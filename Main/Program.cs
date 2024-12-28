

using System;

namespace Main;

//parent
class Armure  
{

        public int Defense {get;set;} = 3 ;
        
        public int Durabiliter {get;set;} = 20 ;

        public Armure(int Defense,int Durabiliter){
        this.Defense = Defense;
        this.Durabiliter = Durabiliter;
        }

        public static Armure operator +(Armure a,Armure b)
        {
            return new Armure(a.Defense + b.Defense , a.Durabiliter+b.Durabiliter);
        }

        public static bool operator true(Armure a) => a.Durabiliter >=1;

        public static bool operator false(Armure a) => a.Durabiliter <=0;



        public override String ToString(){
            if (this.Durabiliter >20)
            {
                return "armure forte";
            }
            else if (this.Durabiliter < 20 && this.Durabiliter > 0)
            {
                return "armure faible";
            }
            else 
            {
                return "armure casser";
            }
             
        }
    }


class Program
{

    
    static void Main(string[] args)
    {
        Armure arm1 = new Armure(18,22);
        Console.WriteLine(arm1);
        Console.WriteLine($"DEF {arm1.Defense} DUR {arm1.Durabiliter}");

        if (arm1){
            Console.WriteLine("armure en utilisable"+"\n");
        }
        else{
            Console.WriteLine("armure casser"+"\n");
        }


        Armure arm2 = new Armure(2,18);
        Console.WriteLine(arm2);
        Console.WriteLine($"DEF {arm2.Defense} DUR {arm2.Durabiliter}");

        if (arm2){
            Console.WriteLine("armure en utilisable"+"\n");
        }
        else{
            Console.WriteLine("armure casser"+"\n");
        }

        Armure armultra = arm1 + arm2;
        Console.WriteLine(armultra);
        Console.WriteLine($"DEF {armultra.Defense} DUR {armultra.Durabiliter}");

        if (armultra){
            Console.WriteLine("armure en utilisable"+"\n");
        }
        else{
            Console.WriteLine("armure casser"+"\n");
        }

        Armure casser = new Armure(55,0);
        Console.WriteLine(casser);
        Console.WriteLine($"DEF {casser.Defense} DUR {casser.Durabiliter}");

        if (casser){
            Console.WriteLine("armure en utilisable"+"\n");
        }
        else{
            Console.WriteLine("armure casser"+"\n");
        }


    }
}
