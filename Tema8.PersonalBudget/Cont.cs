using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8.PersonalBudget
{
    public class Cont
    {
        public int ID { get; set; } = 0;
        public string Nume { get; set; }         //Numele detinatorului contului
        public string Prenume { get; set; }

        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public string Detalii { get; set; }      //Detalii despre detinatorul contului
        public string Moneda { get; set; }       //Tipul monedei
        public string Tranzactii { get; set; }   //Istoricul Tranzactiilor
        public float Venit { get; set; }         //Venitul Detinatorului
        public float Cheltuieli { get; set; }    //Cheltuielile Detinatorului
        public float Economii { get; set; }      //Economiile Detinatorului
        public float Sold { get; set; }          //Soldul bancar fara Economiii
        public Boolean Status = true;            //Cont inchis sau deschis
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
                        string[] temp = sir.Split(' ');
                        Nume = temp[0];
                        Prenume = temp[1];
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
        public Cont(int id, string numecomplet,string detalii, string moneda,
            float sold, float venit, float cheltuieli, float economii)
        {
            ID = id;
            string[] temp = numecomplet.Split(' ');
            Nume = temp[0];
            Prenume = temp[1];
            Detalii = detalii;
            Moneda = moneda;
            Sold = sold;
            Venit = venit;
            Cheltuieli = cheltuieli;
            Economii = economii;
        }
    }
}
