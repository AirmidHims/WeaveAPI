using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class YarnInwardparam
    {
        public InsertYarnInward InsertYarnInward { get; set; }

        public UpdateYarnInward UpdateYarnInward { get; set; }
    }

    public class InsertYarnInward
    {
       

        public int YarnInwardID { get; set; }
        //public String YarnInwardCode { get; set; }

        public DateTime EntryDate { get; set; }
        public String ChallanNo { get; set; }

        public DateTime ChallanDate { get; set; }
        public String LotNo { get; set; }
        public int AccountId { get; set; }
        public int TotalBags { get; set; }
        public float TotalWeight { get; set; }
        public float TotalAmount { get; set; }
        public String AuthorisedBy { get; set; }
        public String CheckedBy { get; set; }
        public int TransportId { get; set; }
        public String VehichleNo { get; set; }
        public String Remarks { get; set; }
        
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateYarnInward
    {

        public String Operation { get; set; }
        public int YarnInwardID { get; set; }
       // public String YarnInwardCode { get; set; }

        public DateTime EntryDate { get; set; }
        public String ChallanNo { get; set; }

        public DateTime ChallanDate { get; set; }
        public String LotNo { get; set; }
        public int AccountId { get; set; }
        public int TotalBags { get; set; }
        public float TotalWeight { get; set; }
        public float TotalAmount { get; set; }
        public String AuthorisedBy { get; set; }
        public String CheckedBy { get; set; }
        public int TransportId { get; set; }
        public String VehichleNo { get; set; }
        public String Remarks { get; set; }

        public String UpdatedBy { get; set; }

    }

}