﻿using ContModel;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddCont(Cont s);
        Cont[] GetConturi(out int nrConturi);
    }
}