using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8.PersonalBudget
{
    public class Cont
    {
        public int ID;
        public string Nume;         //Numele detinatorului contului
        public string Detalii;      //Detalii despre detinatorul contului
        public string Moneda;       //Tipul monedei
        public string Tranzactii;   //Istoricul Tranzactiilor
        public float Venit;         //Venitul Detinatorului
        public float Cheltuieli;    //Cheltuielile Detinatorului
        public float Economii;      //Economiile Detinatorului
        public float Sold;          //Soldul bancar fara Economiii
        public Boolean Status = true;//Cont inchis sau deschis
        public string Afisare()
        {
            string afisare;
            afisare = Nume + "\n" + Detalii + "\n" + Moneda + "\n" + Sold;
            return afisare;
        }
        public float AdaugareVenit(float NouVenit )
        {
            return Venit = Venit + NouVenit;
        }
        public float AdaugareCheltuieli(float NouCheltuieli)
        {
            return Cheltuieli = Cheltuieli + NouCheltuieli;
        }
        public float AdaugareEconomii(float NouEnonomii)
        {
            return Economii = Economii + NouEnonomii;
        }
        public Cont(int id,string nume,string detalii,string moneda,
            float sold, float venit, float cheltuieli, float economii)
        {
            ID = id;
            Nume = nume;
            Detalii = detalii;
            Moneda = moneda;
            Sold = sold;
            Venit = venit;
            Cheltuieli = cheltuieli;
            Economii = economii;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Cont cont1 = new Cont(10,"Boghean Valentin","Student","RON",1234,1200,1256,100);
            Console.WriteLine(cont1.Afisare());
            Console.ReadLine();
        }
    }
}
