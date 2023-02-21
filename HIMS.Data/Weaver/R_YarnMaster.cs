using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
    public class R_YarnMaster : GenericRepository, I_YarnMaster
    {

        public R_YarnMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }
        public bool Insert(Yarnmasterparam Yarnmasterparam)
        {
            //  throw new NotImplementedException();


            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@yID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = Yarnmasterparam.YarmInsert.ToDictionary();
            disc.Remove("yID");
            ExecNonQueryProcWithOutSaveChanges("Insert_YarnMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(Yarnmasterparam Yarnmasterparam)
        {
            // throw new NotImplementedException();

            var disc = Yarnmasterparam.YarmUpdate.ToDictionary();
           // disc.Remove("yID");
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_YarnMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
