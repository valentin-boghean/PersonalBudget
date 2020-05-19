using ContModel;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddCont(Cont s);
        List<Cont> GetConturi();
        Cont GetContByIndex(int index);
        Cont GetCont(string nume, string prenume);
        bool UpdateCont(Cont c);
    }
}
