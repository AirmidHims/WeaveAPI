using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
  public  class R_INVQualitymaster:GenericRepository,I_INVQualitymaster
    {
        public R_INVQualitymaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVQualitymasterparam INVQualitymasterparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@QualityId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVQualitymasterparam.InsertQualitymaster.ToDictionary();
            disc.Remove("QualityId");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_QualityMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVQualitymasterparam INVQualitymasterparam)
        {
            // throw new NotImplementedException();

            var disc = INVQualitymasterparam.UpdatetQualitymaster.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_QualityMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
