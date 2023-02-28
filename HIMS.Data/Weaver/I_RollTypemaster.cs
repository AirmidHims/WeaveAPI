using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
    public interface I_RollTypemaster
    {
        public String Insert(Rolltypemasterparam Rolltypemasterparam);

        public bool Update(Rolltypemasterparam Rolltypemasterparam);
    }
}
