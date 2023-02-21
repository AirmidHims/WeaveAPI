using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
  public  interface I_WeaveItemmaster
    {
        public String Insert(ItemMasterparam ItemMasterparam);

        public bool Update(ItemMasterparam ItemMasterparam);
    }
}
