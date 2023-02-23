using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVLoommaster:GenericRepository,I_INVLoommaster
    {
        public R_INVLoommaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVLoommasterparam INVLoommasterparam)
        {
            //throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@LoomId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVLoommasterparam.InsertLoommaster.ToDictionary();
            disc.Remove("LoomId");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_LoomMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVLoommasterparam INVLoommasterparam)
        {
            //throw new NotImplementedException();

            var disc = INVLoommasterparam.UpdatetLoommaster.ToDictionary();
            var id = ExecNonQueryProcWithOutSaveChanges("Upd_Del_LoomMaster", disc);

            _unitofWork.SaveChanges();
            return (true);
        }
    }
}
