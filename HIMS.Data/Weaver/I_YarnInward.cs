using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_YarnInward
    {
        public String Insert(YarnInwardparam YarnInwardparam);

        public bool Update(YarnInwardparam YarnInwardparam);
    }
}
