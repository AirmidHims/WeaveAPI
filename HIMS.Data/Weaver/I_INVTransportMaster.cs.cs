﻿using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
  public  interface I_INVTransportMaster
    {
        public String Insert(INVTransportMasterparam INVTransportMasterparam);

        public bool Update(INVTransportMasterparam INVTransportMasterparam);
    }
}
