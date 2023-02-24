using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVTransportMaster:GenericRepository,I_INVTransportMaster
    {
        public R_INVTransportMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVTransportMasterparam INVTransportMasterparam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@TransportID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVTransportMasterparam.InsertTransport.ToDictionary();
            disc.Remove("TransportID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_TransportMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVTransportMasterparam INVTransportMasterparam)
        {
            //throw new NotImplementedException();

            var disc = INVTransportMasterparam.UpdateTransport.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_TransportMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
