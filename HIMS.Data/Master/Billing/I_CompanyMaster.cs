﻿using HIMS.Model.Master.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master.Billing
{
   public interface I_CompanyMaster
    {
        bool Update(CompanyMasterParams CompanyMasterParams);
        bool Save(CompanyMasterParams CompanyMasterParams);
    }
}
