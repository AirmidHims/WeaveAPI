using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_MillMaster
    {
        public String Insert(Millmasterparam Millmasterparam);

        public bool Update(Millmasterparam Millmasterparam);
    }
}
