using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_LoomTypemaster
    {
        public String Insert(LoomTypemasterparam LoomTypemasterparam);

        public bool Update(LoomTypemasterparam LoomTypemasterparam);
    }
}
