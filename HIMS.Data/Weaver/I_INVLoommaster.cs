using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVLoommaster
    {
        public String Insert(INVLoommasterparam INVLoommasterparam);

        public bool Update(INVLoommasterparam INVLoommasterparam);
    }
}
