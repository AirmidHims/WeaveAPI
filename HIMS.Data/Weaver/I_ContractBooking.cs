using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_ContractBooking
    {
        public String Insert(ContractBookingparam ContractBookingparam);

        public bool Update(ContractBookingparam ContractBookingparam);
    }
}
