using HIMS.Common.Utility;
using HIMS.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Inventory
{
    public class R_Workorder : GenericRepository, I_Workorder
    {
        public R_Workorder(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(Workorderparam Workorderparam)
        {
            // throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@WOId",
                Value = 0,
                Direction = ParameterDirection.Output
            };
          

            var disc2 = Workorderparam.WorkorderHeaderInsert.ToDictionary();
            disc2.Remove("WOId");
            var wID = ExecNonQueryProcWithOutSaveChanges("insert_T_WorkOrderHeader_1", disc2, outputId);

            Workorderparam.WorkorderDetailInsert.WOId = Convert.ToInt32(wID);
            var disc1 = Workorderparam.WorkorderDetailInsert.ToDictionary();
            //disc1.Remove("AdmissionID");
            var wID1 = ExecNonQueryProcWithOutSaveChanges("insert_T_WorkOrderDetail_1", disc1);

          
            _unitofWork.SaveChanges();
            return (wID);
        }

       
    }
}
