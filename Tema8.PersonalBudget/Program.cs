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
            Cont[] conturi = new Cont[100];
            int nrConturi = 0;
            Cont.IdUltimCont = nrConturi;
            string optiune;
            do
            {
                Console.WriteLine("L. Listare Conturi");
                Console.WriteLine("A. Adaugare cont tastatura");
                Console.WriteLine("C. Compara doua conturi");
                Console.WriteLine("M. Modificare Cont");
                Console.WriteLine("X. Iesire Program");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "L":
                        AfisareConturi(conturi, nrConturi);
                        break;
                    case "A":
                        Cont c = CitireContTastatura();
                        conturi[nrConturi] = c;
                        nrConturi++;
                        break;
                    case "C":
                        AfisareConturi(conturi, nrConturi);
                        Console.WriteLine("Dati ID cont 1: ");
                        int id1;
                        Int32.TryParse(Console.ReadLine(), out id1);
                        Console.WriteLine("Dati ID cont 2: ");
                        int id2;
                        Int32.TryParse(Console.ReadLine(), out id2);
                        if (Comparare(conturi[id1], conturi[id2]))
                            Console.WriteLine("Conturile au acelasi detinator.");
                        else
                            Console.WriteLine("Conturile nu au acelasi detinator");
                        break;
                    case "M":
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }
            } while (optiune.ToUpper() != "X");
            Console.ReadLine();
        }

            public static void AfisareConturi(Cont[] conturi,int nrConturi)
            {
                Console.WriteLine("Conturile sunt: ");
                for (int i = 0; i < nrConturi; i++)
                    Console.WriteLine(conturi[i].ConversieLaSir());

            }

            public static Cont  CitireContTastatura()
            {
                Console.Write("Introduceti numele: ");
                string nume = Console.ReadLine();
                Console.Write("Introduceti prenumele: ");
                string prenume = Console.ReadLine();
                Console.Write("Dati venitul pe ultima luna: ");
                int venit;
                Int32.TryParse(Console.ReadLine(), out venit);
                Console.Write("Dati cheltuielile pe ultima luna: ");
                int cheltuieli;
                Int32.TryParse(Console.ReadLine(),out cheltuieli);
                Cont c = new Cont(nume, prenume, venit, cheltuieli);
                return c;
            }

            //Compara doua conturi daca 2 conturi au acelasi detinator
            public static bool Comparare(Cont c1, Cont c2)
            {
                if (c1.Nume == c2.Nume && c1.Prenume == c2.Prenume)
                    return true;
            return false;
            }
            
        }
    
}
