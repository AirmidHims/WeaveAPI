using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_BeamInward:GenericRepository,I_BeamInward
    {
        public R_BeamInward(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(BeamInwardparam BeamInwardparam)
        {
            // throw new NotImplementedException();
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@BeamInwardID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = BeamInwardparam.InsertBeamInward.ToDictionary();
            disc.Remove("BeamInwardID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_BeamInwardDetails", disc, outputId1);

            foreach (var a in BeamInwardparam.InsertBeamInwardItemList)
            {
                var disc1 = a.ToDictionary();
                disc1["BeamInwardId"] = id;
                a.BeamInwardId = BeamInwardparam.InsertBeamInward.BeamInwardID;
                ExecNonQueryProcWithOutSaveChanges("Insert_BeamInwardList", disc1);
            }


            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(BeamInwardparam BeamInwardparam)
        {
            // throw new NotImplementedException();
            var disc = BeamInwardparam.UpdateBeamInward.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_BeamInwardDetails", disc);


            foreach (var a in BeamInwardparam.UpdateBeamInwardItemList)
            {

                var disc1 = a.ToDictionary();
                disc1["BeamInwardID"] = BeamInwardparam.UpdateBeamInward.BeamInwardID;
                ExecNonQueryProcWithOutSaveChanges("Upd_Del_BeamInwardList", disc1);
            }
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
