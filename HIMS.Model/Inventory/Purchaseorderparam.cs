using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Inventory
{
  public  class Purchaseorderparam
    {
        public PurchaseorderHeaderInsert PurchaseorderHeaderInsert { get; set; }

        public PurchaseorderDetailsInsert PurchaseorderDetailsInsert { get; set; }

    }

    public class PurchaseorderHeaderInsert
    {
 
         public DateTime PurchaseDate { get; set; }

        public DateTime PurchaseTime { get; set; }

        public int StoreId { get; set; }
        public int SupplierID { get; set; }


        public float TotalAmount { get; set; }
        public float DiscAmount { get; set; }

        public float TaxAmount { get; set; }
        public float FreightAmount { get; set; }

        public float OctriAmount { get; set; }
        public float GrandTotal { get; set; }
              
           
        public bool Isclosed { get; set; }
        public bool IsVerified { get; set; }

        public String Remarks { get; set; }
        public int TaxID { get; set; }


        public int IsCancelledBy { get; set; }
        public int WOId { get; set; }


        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }

        public String Worrenty { get; set; }
        public float RoundVal { get; set; }


        public float TotCGSTAmt { get; set; }
        public float TotSGSTAmt { get; set; }

        public float TotIGSTAmt { get; set; }
        public float TransportChanges { get; set; }

        public float HandlingCharges { get; set; }
        public int PurchaseId { get; set; }

        public float FreightCharges { get; set; }
    }

    public class PurchaseorderDetailsInsert
    {

        public DateTime PurchaseDate { get; set; }

        public DateTime PurchaseTime { get; set; }

        public int StoreId { get; set; }
        public int SupplierID { get; set; }


        public float TotalAmount { get; set; }
        public float DiscAmount { get; set; }

        public float TaxAmount { get; set; }
        public float FreightAmount { get; set; }

        public float OctriAmount { get; set; }
        public float GrandTotal { get; set; }


        public bool Isclosed { get; set; }
        public bool IsVerified { get; set; }

        public String Remarks { get; set; }
        public int TaxID { get; set; }


        public int IsCancelledBy { get; set; }
        public int WOId { get; set; }


        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }

        public String Worrenty { get; set; }
        public float RoundVal { get; set; }


        public float TotCGSTAmt { get; set; }
        public float TotSGSTAmt { get; set; }

        public float TotIGSTAmt { get; set; }
        public float TransportChanges { get; set; }

        public float HandlingCharges { get; set; }
        public int PurchaseId { get; set; }

        public float FreightCharges { get; set; }
    }
}
