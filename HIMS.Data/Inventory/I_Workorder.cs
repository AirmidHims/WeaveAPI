using HIMS.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Inventory
{
   public interface I_Workorder
    {
        public String Insert(Workorderparam Workorderparam);

       // public bool Update(Workorderparam Workorderparam);
    }
}
