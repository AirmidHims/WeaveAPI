using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_DdesignMaster
    {
        public String Insert(DesignMasterParam DesignMasterParam);

        public bool Update(DesignMasterParam DesignMasterParam);
    }
}
