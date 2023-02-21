using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.IPD
{
   public class GRNReturnparam1
    {
      public InsertGRNReturn InsertGRNReturn { get; set; }
        public UpdateGRNReturn UpdateGRNReturn { get; set; }

    }

    public class UpdateGRNReturn
    {

        public int GrnReturnId { get; set; }
        public int ItemId { get; set; }
        public DateTime @BatchExpiryDate { get; set; }

        public int ReturnQty { get; set; }

        public int LandedRate { get; set; }

        public int Mrp { get; set; }
        public int UnitPurchaseRate { get; set; }
        public float VatPercentage { get; set; }
        public int VatAmount { get; set; }

        public int TaxAmount { get; set; }
        public float OctroiPer { get; set; }


        public int OctroiAmt { get; set; }

        public int AnesthetishID2 { get; set; }
        public float LandedTotalAmount { get; set; }

        public float MrpTotalAmount { get; set; }
        public float PurchaseTotalAmount { get; set; }

        public float Conversion { get; set; }

        public String Remarks { get; set; }
        public int StkId { get; set; }
        public int Cf { get; set; }

        public int TotalQty { get; set; }

        public int GrnId { get; set; }
       


    }

    public class InsertGRNReturn
    {

        public int GrnReturnId { get; set; }
        public int ItemId { get; set; }
        public DateTime BatchExpiryDate { get; set; }

        public int ReturnQty { get; set; }

        public int LandedRate { get; set; }

        public int Mrp { get; set; }
        public int UnitPurchaseRate { get; set; }
        public float VatPercentage { get; set; }
        public int VatAmount { get; set; }

        public int TaxAmount { get; set; }
        public float OctroiPer { get; set; }


        public int OctroiAmt { get; set; }

        public int AnesthetishID2 { get; set; }
        public float LandedTotalAmount { get; set; }

        public float MrpTotalAmount { get; set; }
        public float PurchaseTotalAmount { get; set; }

        public float Conversion { get; set; }

        public String Remarks { get; set; }
        public int StkId { get; set; }
        public int Cf { get; set; }

        public int TotalQty { get; set; }

        public int GrnId { get; set; }



    }
}
