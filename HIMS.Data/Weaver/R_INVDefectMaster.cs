using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVDefectMaster:GenericRepository,I_INVDefectMaster
    {
        public R_INVDefectMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVDefectMasterparam INVDefectMasterparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@DefectID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVDefectMasterparam.InsertDefect.ToDictionary();
            disc.Remove("DefectID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_DefectMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVDefectMasterparam INVDefectMasterparam)
        {
            // throw new NotImplementedException();
            var disc = INVDefectMasterparam.UpdateDefect.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_DefectMaster", disc);

            _unitofWork.SaveChanges();
            return true;

        }
    }
}
