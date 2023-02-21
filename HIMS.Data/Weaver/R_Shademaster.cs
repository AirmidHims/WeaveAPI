using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
    public class R_Shademaster : GenericRepository, I_Shademaster
    {

        public R_Shademaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }
        public String Insert(Shademasterparam Shademasterparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@shadeID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = Shademasterparam.ShadeInsert.ToDictionary();
            disc.Remove("shadeID");
            var id=ExecNonQueryProcWithOutSaveChanges("Insert_ShadeMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(Shademasterparam Shademasterparam)
        {
            // throw new NotImplementedException();
            var disc = Shademasterparam.ShadeUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_ShadeMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
