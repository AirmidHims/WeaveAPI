using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
    public class R_MillMaster : GenericRepository, I_MillMaster
    {

        public R_MillMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }
        public string Insert(Millmasterparam Millmasterparam)
        {
            //  throw new NotImplementedException();


            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@MillID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = Millmasterparam.MillInsert.ToDictionary();
            disc.Remove("MillID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_MillMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(Millmasterparam Millmasterparam)
        {
            // throw new NotImplementedException();

            var disc = Millmasterparam.MillUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_MillMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
