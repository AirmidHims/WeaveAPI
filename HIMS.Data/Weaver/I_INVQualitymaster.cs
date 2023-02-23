using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_INVQualitymaster
    {
        public String Insert(INVQualitymasterparam INVQualitymasterparam);

        public bool Update(INVQualitymasterparam INVQualitymasterparam);
    }
}
