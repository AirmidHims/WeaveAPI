using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVLocationmaster:GenericRepository,I_INVLocationmaster
    {
        public R_INVLocationmaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVLocationmasterparam INVLocationmasterparam)
        {
            //  throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@LocationID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVLocationmasterparam.InsertLocationmaster.ToDictionary();
            disc.Remove("LocationID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_LocationMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVLocationmasterparam INVLocationmasterparam)
        {
            // throw new NotImplementedException();

            var disc = INVLocationmasterparam.UpdateLocationmaster.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_LocationMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
