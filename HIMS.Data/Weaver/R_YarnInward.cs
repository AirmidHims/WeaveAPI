using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_YarnInward :GenericRepository,I_YarnInward
    {
        public R_YarnInward(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(YarnInwardparam YarnInwardparam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@YarnInwardID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = YarnInwardparam.InsertYarnInward.ToDictionary();
            disc.Remove("YarnInwardID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_YarnInwardMaster", disc, outputId1);

            foreach (var a in YarnInwardparam.InsertYarnInwardItemList)
            {
                var disc1 = a.ToDictionary();
                disc1["YarnInwardID"] = id;
                 ExecNonQueryProcWithOutSaveChanges("Insert_YarnInwardList", disc1);
            }

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(YarnInwardparam YarnInwardparam)
        {
            // throw new NotImplementedException();
            var disc = YarnInwardparam.UpdateYarnInward.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_YarnInwardMaster", disc);


            foreach (var a in YarnInwardparam.UpdateYarnInwardItemList)
            {
               
                var disc1 = a.ToDictionary();
                disc1["YarnInwardID"] = YarnInwardparam.UpdateYarnInward.YarnInwardID;
                ExecNonQueryProcWithOutSaveChanges("Upd_Del_YarnInwardList", disc1);
            }


            _unitofWork.SaveChanges();
            return true;
        }
    }
}
