using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
    public class R_RollTypemaster :GenericRepository,I_RollTypemaster
    {

        public R_RollTypemaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(Rolltypemasterparam Rolltypemasterparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {

                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@RollTypeId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = Rolltypemasterparam.InsertRollTypenmaster.ToDictionary();
            disc.Remove("RollTypeId");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_RollTypeMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(Rolltypemasterparam Rolltypemasterparam)
        {
            //throw new NotImplementedException();

            var disc = Rolltypemasterparam.UpdateRollTypemaster.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_RollTypeMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
