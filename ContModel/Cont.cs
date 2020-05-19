using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContModel
{
    public class Cont
    {
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int SOLD = 3;
        private const int MONEDA = 4;
        private const int VENITURI = 5;
        private const int CHELTUIELI = 6;

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        
        public int IdCont { get; set; }
        public string Nume { get; set; }         //Numele detinatorului contului
        public string Prenume { get; set; }

        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public string Detalii { get; set; }      //Detalii despre detinatorul contului
        //public string Tranzactii { get; set; }   //Istoricul Tranzactiilor
        public float Venit { get; set; }         //Venitul Detinatorului
        public float Cheltuieli { get; set; }    //Cheltuielile Detinatorului
        public float Economii { get; set; }      //Economiile Detinatorului
        public float Sold { get ; set; }          //Soldul bancar fara Economiii
        public Boolean Status = true;            //Cont inchis sau deschis
        public Valuta Moneda { get; set; }

        public int Durata { get; set; }
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
            Detalii = string.Empty;

        }

        public Cont(string _nume, string _prenume, int _venit, int _cheltuieli)
        {

            Nume = _nume;
            Prenume = _prenume;
            Venit = (float)_venit;
            Cheltuieli = (float)_cheltuieli;
            Sold = Venit - Cheltuieli;
        }
        // Constructorul pentru preluarea din fisier
        public Cont(string _SirInput)
        {
            
            string[] SirInput = new string[_SirInput.Length];
            SirInput = _SirInput.Split(';');
            int temp;
            int i = 0;
            foreach (string sir in SirInput)
            {
                switch(i)
                {
                    case 0:      
                        Int32.TryParse(sir, out temp);
                        IdCont = temp;                    
                        break;
                    case 1:
                        Nume = sir;
                        break;
                    case 2:
                        Prenume = sir;
                        break;
                    case 4:
                        Moneda = (Valuta)Enum.Parse(typeof(Valuta),sir);
                        break;
                    case 3:                       
                        Int32.TryParse(sir, out temp);
                        Sold = temp;
                        break;
                    case 5:                     
                        Int32.TryParse(sir, out temp);
                        Venit = temp;
                        break;
                    case 6:              
                        Int32.TryParse(sir, out temp);
                        Cheltuieli = temp;
                        break;
                    case 7:
                        Durata = Int32.Parse(sir);
                        break;
                    default:
                        break;

                }
                i++;
            }
        }
        /*public Cont(string numecomplet,string detalii, string moneda,
            float sold, float venit, float cheltuieli, float economii)
        {
            
            IdCont =
            string[] temp = numecomplet.Split(' ');
            Nume = temp[0];
            Prenume = temp[1];
            Detalii = detalii;
            Moneda = (Valuta)Int32.Parse(moneda);
            Sold = sold;
            Venit = venit;
            Cheltuieli = cheltuieli;
            Economii = economii;
        }
        */

        public string ConversieLaSir()
        {
            string s = string.Format("{0,-2}{1,10}{2,10}{3,10}{4,10}{5,15}{6,15}{7,10}", IdCont, Nume,Prenume, Sold, Moneda, Venit, Cheltuieli,Durata);
            return s;        
        }

        public string ConversieLaSir_PentruFisier()
        {
            
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER, IdCont.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), Sold, Moneda,Venit,Cheltuieli,Durata);

            return s;
        }
    }
}
