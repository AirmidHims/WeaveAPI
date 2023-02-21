using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_Shademaster
    {
        public String Insert(Shademasterparam Shademasterparam);

        public bool Update(Shademasterparam Shademasterparam);
    }
}
