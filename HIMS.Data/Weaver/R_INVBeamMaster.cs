using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_INVBeamMaster:GenericRepository,I_INVBeamMaster
    {
        public R_INVBeamMaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(INVBeamMasterparam INVBeamMasterparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@BeamID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = INVBeamMasterparam.InsertBeam.ToDictionary();
            disc.Remove("BeamID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_BeamMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(INVBeamMasterparam INVBeamMasterparam)
        {
            /// throw new NotImplementedException();
            
            var disc = INVBeamMasterparam.UpdateBeam.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_BeamMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
