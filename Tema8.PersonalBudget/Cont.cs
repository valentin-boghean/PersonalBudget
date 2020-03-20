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
        public float Venit;         //Venitul Detinatorului
        public float Cheltuieli;    //Cheltuielile Detinatorului
        public float Economii;      //Economiile Detinatorului
        public float Sold;          //Soldul bancar fara Economiii
        public Boolean Status = true;//Cont inchis sau deschis
        public string Afisare()
        {
            string afisare;
            afisare = Nume + "\t" + Detalii + "\t" + Moneda + "\t" + Sold;
            return afisare;
        }
        public float AdaugareVenit(float NouVenit)
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

        public Cont()
        {
            Nume = string.Empty;           
            Moneda = string.Empty;
            Detalii = String.Empty;

        }

        // Constructorul pentru preluarea din fisier
        public Cont(string _SirInput)
        {
            string[] SirInput = new string[_SirInput.Length];
            SirInput = _SirInput.Split(',');
            int i = 0;
            foreach(string sir in SirInput)
            {
                switch(i)
                {
                    case 0:
                        ID = Convert.ToInt32(sir);
                        break;
                    case 1:
                        Nume = sir;
                        break;
                    case 2:
                        Detalii = sir;
                        
                        break;
                    case 3:
                        Moneda = sir;
                        break;
                    case 4:
                        Sold = Convert.ToInt32(sir);
                        break;
                    case 5:
                        Venit = Convert.ToInt32(sir);
                        break;
                    case 6:
                        Cheltuieli = Convert.ToInt32(sir);
                        break;
                    case 7:
                        Economii = Convert.ToInt32(sir);
                        break;
                    default:
                        break;

                }
                i++;
            }
        }
        public Cont(int id, string nume,string detalii, string moneda,
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
}
