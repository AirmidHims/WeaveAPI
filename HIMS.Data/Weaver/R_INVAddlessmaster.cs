using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVAddlessmaster:GenericRepository,I_INVAddlessmaster
    {
        public R_INVAddlessmaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVAddlessmasterparam INVAddlessmasterparam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@AddLessID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVAddlessmasterparam.InsertAddless.ToDictionary();
            disc.Remove("AddLessID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_AddLessMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVAddlessmasterparam INVAddlessmasterparam)
        {
            // throw new NotImplementedException();

            var disc = INVAddlessmasterparam.UpdateAddless.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_AddLessMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
