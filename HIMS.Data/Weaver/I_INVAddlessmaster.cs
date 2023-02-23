using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVAddlessmaster
    {
        public String Insert(INVAddlessmasterparam INVAddlessmasterparam);

        public bool Update(INVAddlessmasterparam INVAddlessmasterparam);
    }
}
