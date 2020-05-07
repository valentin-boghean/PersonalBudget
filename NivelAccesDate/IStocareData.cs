using ContModel;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddCont(Cont s);
        ArrayList GetConturi();
        Cont GetCont(string nume, string prenume);
        bool UpdateCont(Cont c);
    }
}
