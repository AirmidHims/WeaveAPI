using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.IPD
{
   public interface I_Customer_complaint
    {
        public bool Insert(Customercomplaintparam Customercomplaintparam);
        public bool Update(Customercomplaintparam Customercomplaintparam);
    }

}


