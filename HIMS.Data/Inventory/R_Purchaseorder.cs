using HIMS.Common.Utility;
using HIMS.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Inventory
{
    public class R_Purchaseorder : GenericRepository, I_Purchaseorder
    {

        public R_Purchaseorder(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public string Insert(Purchaseorderparam Purchaseorderparam)
        {
            //throw new NotImplementedException();
            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@WOId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var disc2 = Purchaseorderparam.PurchaseorderHeaderInsert.ToDictionary();
            disc2.Remove("WOId");
            var wID = ExecNonQueryProcWithOutSaveChanges("insert_PurchaseHeader_WithPurNo_1", disc2, outputId);

            Purchaseorderparam.PurchaseorderDetailsInsert.WOId = Convert.ToInt32(wID);
            var disc1 = Purchaseorderparam.PurchaseorderDetailsInsert.ToDictionary();
            //disc1.Remove("AdmissionID");
            var wID1 = ExecNonQueryProcWithOutSaveChanges("insert_PurchaseDetails_1", disc1);


            _unitofWork.SaveChanges();
            return (wID);
        }
    }
}
