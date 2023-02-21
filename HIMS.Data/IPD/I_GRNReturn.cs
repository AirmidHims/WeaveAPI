using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.IPD
{
    public interface I_GRNReturn
    {
       public bool Insert(GRNReturnparam1 GRNReturnparam1);

        public bool Update(GRNReturnparam1 GRNReturnparam1);
    }
}
