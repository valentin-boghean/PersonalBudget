using System;      
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;
using ContModel;

namespace PersonalBudget
{

    class Program
    {

        static void Main(string[] args)
        {
            Cont[] conturi;
            IStocareData adminConturi = StocareFactory.GetAdministratorStocare();
            int nrConturi;
            conturi = adminConturi.GetConturi(out nrConturi);
            Cont.IdUltimCont = nrConturi;
          
            string optiune;
            do
            {
                Console.WriteLine("L. Listare Conturi");
                Console.WriteLine("A. Adaugare cont tastatura");
                Console.WriteLine("C. Compara doua conturi");
                Console.WriteLine("M. Modificare Cont");
                Console.WriteLine("X. Iesire Program");
                Console.WriteLine();
                Console.Write("Dati optiunea: ");
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
                        adminConturi.AddCont(c);
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
                        Console.WriteLine("1. Modificati nume si prenume.");
                        Console.WriteLine("2. Stergeti cont");
                        int opt;
                        Int32.TryParse(Console.ReadLine(), out opt);
                        switch(opt)
                        {
                            case 1:
                                AfisareConturi(conturi, nrConturi);
                                Console.Write("Dati ID: ");
                                int id;
                                Int32.TryParse(Console.ReadLine(), out id);
                                ModificareNume(conturi[id]);
                                break;
                            case 2:
                                AfisareConturi(conturi, nrConturi);
                                Console.Write("Dati ID: ");
                               /// int id;
                                Int32.TryParse(Console.ReadLine(), out id);                              
                                StergeCont(conturi,ref nrConturi, id);
                                break;
                            default:
                                break;
                        }                        

                        break;
                    case "X":Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }
                Console.ReadLine();
                Console.Clear();
                
            } while (optiune.ToUpper() != "X");
            
            Console.ReadLine();
        }

        public static void AfisareConturi(Cont[] conturi, int nrConturi)
        {
            var header = string.Format("{0,-2}{1,10}{2,10}{3,10}{4,10}{5,15}{6,15}", "ID", "Nume", "Prenume","Sold","Valuta", "Venit/Luna", "Cheltuieli");
            Console.WriteLine("{0}", header);
            Console.WriteLine("-------------------------------------------------------------------------");
           
            for (int i = 0; i < nrConturi; i++)
                Console.WriteLine(conturi[i].ConversieLaSir());
        }

        public static Cont CitireContTastatura()
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
            Int32.TryParse(Console.ReadLine(), out cheltuieli);
            Cont c = new Cont(nume, prenume, venit, cheltuieli);
 
            Console.WriteLine("Valuta disponibila:");
            Console.WriteLine("1 - USD \n" +
            "2 - EUR \n" +
            "3 - GBP \n" +
            "4 - RON \n");
            Console.WriteLine("Alege moneda:");
            c.Moneda = (Valuta)Int32.Parse(Console.ReadLine());

            return c;
        }

        //Compara doua conturi daca 2 conturi au acelasi detinator
        public static bool Comparare(Cont c1, Cont c2)
        {
            if (c1.Nume == c2.Nume && c1.Prenume == c2.Prenume)
                return true;
            return false;
        }

        public static Cont ModificareNume(Cont c1)

        {
            Console.Write("Dati nume nou: ");
            c1.Nume = Console.ReadLine();
            Console.Write("Dati prenume nou: ");
            c1.Prenume = Console.ReadLine();
            return c1;
        }

        public static void StergeCont(Cont[] conturi,ref int nrConturi, int id)
        {
            for (int i = id; i < nrConturi - 1; i++)
            {
                conturi[id] = conturi[++id];
                conturi[id].IdCont = id-1;
            }
            
            nrConturi--;
            Cont.IdUltimCont = nrConturi;

        }

    }

}
