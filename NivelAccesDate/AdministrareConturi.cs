using ContModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareConturi_FisierText implementeaza interfata IStocareData
    public class AdministrareConturi : IStocareData
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareConturi(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddCont(Cont cont)
        {
            cont.IdCont = GetId();
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(cont.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Cont> GetConturi()
        {
            List<Cont> conturi = new List<Cont>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Cont pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Cont s = new Cont(line);
                        conturi.Add(s);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return conturi;
        }

        public Cont GetCont(string nume, string prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Cont pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Cont cont = new Cont(line);
                        if (cont.Nume.Equals(nume) && cont.Prenume.Equals(prenume))
                            return cont;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public Cont GetContByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int contor = 0;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Cont cont = new Cont(line);
                        if (contor == index)
                            return cont;
                        contor++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdateCont(Cont contActualizat)
        {
            List<Cont> conturi = GetConturi();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Cont stud in conturi)
                    {
                        //informatiile despre contul actualizat vor fi preluate din parametrul "contActualizat"
                        if (stud.IdCont != contActualizat.IdCont)
                        {
                            swFisierText.WriteLine(stud.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(contActualizat.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdCont = ID_PRIMUL_STUDENT;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Cont pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Cont s = new Cont(line);
                        IdCont = s.IdCont + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdCont;
        }
    }
}
