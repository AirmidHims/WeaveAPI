using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_Yarnoutwards
    {
        public String Insert(YarnOutwardparam YarnOutwardparam);

        public bool Update(YarnOutwardparam YarnOutwardparam);
    }
}
