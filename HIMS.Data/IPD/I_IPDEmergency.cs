﻿using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.IPD
{
   public interface I_IPDEmergency
    {
        public bool Insert(IPDEmergencyParams IPDEmergencyParams);
    }
}
