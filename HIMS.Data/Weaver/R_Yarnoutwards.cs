using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
   public class R_Yarnoutwards:GenericRepository,I_Yarnoutwards
    {
        public R_Yarnoutwards(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public string Insert(YarnOutwardparam YarnOutwardparam)
        {
            //throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@YarnOutwardID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = YarnOutwardparam.InsertYarnOutward.ToDictionary();
            disc.Remove("YarnOutwardID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_YarnOutwardMaster", disc, outputId1);

            foreach (var a in YarnOutwardparam.InsertYarnOutwardItemList)
            {
                var disc1 = a.ToDictionary();
                disc1["YarnOutwardID"] = id;
                ExecNonQueryProcWithOutSaveChanges("Insert_YarnOutwardList", disc1);
            }

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(YarnOutwardparam YarnOutwardparam)
        {
            // throw new NotImplementedException();

            var disc = YarnOutwardparam.UpdateYarnOutward.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_YarnOutwardMaster", disc);


            foreach (var a in YarnOutwardparam.UpdateYarnOutwardItemList)
            {

                var disc1 = a.ToDictionary();
                disc1["YarnOutwardID"] = YarnOutwardparam.UpdateYarnOutward.YarnOutwardID;
                ExecNonQueryProcWithOutSaveChanges("Upd_Del_YarnOutwardList", disc1);
            }


            _unitofWork.SaveChanges();
            return true;
        }
    }
}
