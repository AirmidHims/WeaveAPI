using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVDefectMaster
    {
        public String Insert(INVDefectMasterparam INVDefectMasterparam);

        public bool Update(INVDefectMasterparam INVDefectMasterparam);
    }
}
