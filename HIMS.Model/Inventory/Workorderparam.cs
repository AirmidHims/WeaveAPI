using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Inventory
{
    public class Workorderparam
    {
        public WorkorderHeaderInsert WorkorderHeaderInsert { get; set; }
        public WorkorderDetailInsert WorkorderDetailInsert { get; set; }

    }

    public class WorkorderHeaderInsert{

     public DateTime Date { get; set; }

    public DateTime Time { get; set; }

        public int StoreId { get; set; }
        public int SupplierId { get; set; }


        public float TotalAmount { get; set; }
        public float VatAmount { get; set; }

        public float DiscAmount { get; set; }
        public float NetAmount { get; set; }


        public bool Isclosed { get; set; }
        public String Remark { get; set; }

        public int AddedBy { get; set; }
        public bool IsCancelled { get; set; }


        public int IsCancelledBy { get; set; }
        public int WOId { get; set; }


        }

    public class WorkorderDetailInsert
    {
    
        public int WOId { get; set; }

        public String ItemName { get; set; }

        public float Qty { get; set; }
        public float Rate { get; set; }


        public float TotalAmount { get; set; }
        public float DiscPer { get; set; }

        public float DiscAmount { get; set; }
        public float VATPer { get; set; }


        public float VATAmount { get; set; }
        public float NetAmount { get; set; }

        public String Remark { get; set; }
       

    }

}
