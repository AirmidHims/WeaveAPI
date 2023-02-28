using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_LoomTypemaster :GenericRepository,I_LoomTypemaster
    {
        public R_LoomTypemaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(LoomTypemasterparam LoomTypemasterparam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {

                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@LoomTypeID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = LoomTypemasterparam.InsertLoomTypenmaster.ToDictionary();
            disc.Remove("LoomTypeID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_LoomTypeMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(LoomTypemasterparam LoomTypemasterparam)
        {
            // throw new NotImplementedException();
            var disc = LoomTypemasterparam.UpdateLoomTypemaster.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_LoomTypeMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
