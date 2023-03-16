using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_BeamInward
    {
        public String Insert(BeamInwardparam BeamInwardparam);

        public bool Update(BeamInwardparam BeamInwardparam);
    }
}
