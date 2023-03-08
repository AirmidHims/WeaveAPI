using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
  public  class R_ContractBooking:GenericRepository,I_ContractBooking
    {
        public R_ContractBooking(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(ContractBookingparam ContractBookingparam)
        {
            // throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ContractBookingID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = ContractBookingparam.InsertContractBooking.ToDictionary();
            disc.Remove("ContractBookingID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_ContractBookingDetails", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(ContractBookingparam ContractBookingparam)
        {
            // throw new NotImplementedException();
            var disc = ContractBookingparam.UpdateContractBooking.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_ContractBookingDetails", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
