using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVBeamMaster
    {
        public String Insert(INVBeamMasterparam INVBeamMasterparam);

        public bool Update(INVBeamMasterparam INVBeamMasterparam);
    }
}
