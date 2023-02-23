using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVLocationmaster
    {
        public String Insert(INVLocationmasterparam INVLocationmasterparam);

        public bool Update(INVLocationmasterparam INVLocationmasterparam);
    }
}
