using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_YarnMaster
    {
        public bool Insert(Yarnmasterparam Yarnmasterparam);
        
        public bool Update(Yarnmasterparam Yarnmasterparam);
    }
}
