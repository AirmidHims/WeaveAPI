using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_DesignMaster:GenericRepository,I_DdesignMaster
    {
        public R_DesignMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(DesignMasterParam DesignMasterParam)
        {
            // throw new NotImplementedException();


            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@DesignID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = DesignMasterParam.InsertDesign.ToDictionary();
            disc.Remove("DesignID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_DesignMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

       

        public bool Update(DesignMasterParam DesignMasterParam)
        {
            // throw new NotImplementedException();
            var disc = DesignMasterParam.UpdateDesign.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_DesignMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
