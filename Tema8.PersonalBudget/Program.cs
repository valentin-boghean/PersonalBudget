using System;      //Test 
using System.Collections.Generic;       //Test 2
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8.PersonalBudget
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Cont cont1 = new Cont(10,"Boghean Valentin","Student","RON",1234,1200,1256,100);
            Cont cont2 = new Cont("9,Elon Musk,SpaceX CEO,$,10000,2000,2000,2000");
            string optiune;
            do
            {
                Console.WriteLine("L. Listare Conturi");
                Console.WriteLine("A. Adaugare cont");
                Console.WriteLine("M. Modificare Cont");
                Console.WriteLine("X. Iesire Program");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "L":
                        break;
                    case "A":
                        break;
                    case "M":
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }
            } while (optiune.ToUpper()!= "X");
            Console.WriteLine(cont1.Afisare());
            Console.WriteLine(cont2.Afisare());
            Console.ReadLine();
        }
    }
}
