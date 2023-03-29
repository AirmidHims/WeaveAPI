using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class YarnInwardparam
    {
        public InsertYarnInward InsertYarnInward { get; set; }

        public List<InsertYarnInwardItemList> InsertYarnInwardItemList { get; set; }

        public UpdateYarnInward UpdateYarnInward { get; set; }

       
        public List<UpdateYarnInwardItemList> UpdateYarnInwardItemList { get; set; }
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
       public String YarnInwardCode { get; set; }

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


    public class InsertYarnInwardItemList
    {

        public int YarnInListID { get; set; }

        public int YarnInwardID { get; set; }

        public int YarnCount { get; set; }
        public int MillID { get; set; }

        public int ShadeId { get; set; }
        public float WtPerBag { get; set; }
        public int ConePerBag { get; set; }
        public int TotalBags { get; set; }
        public float TotalGrossWt { get; set; }
        public float TotalNetWt { get; set; }
        public String Category { get; set; }
        public String Scale { get; set; }
        public float Rate { get; set; }
        public float Amount { get; set; }
        public int LocationId { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateYarnInwardItemList
    {
        public String Operation { get; set; }
        public int YarnInListID { get; set; }
        public String YarnInListCode { get; set; }
        public int YarnInwardID { get; set; }

        public int YarnCount { get; set; }
        public int MillID { get; set; }

        public int ShadeId { get; set; }
        public float WtPerBag { get; set; }
        public int ConePerBag { get; set; }
        public int TotalBags { get; set; }
        public float TotalGrossWt { get; set; }
        public float TotalNetWt { get; set; }
        public String Category { get; set; }
        public String Scale { get; set; }
        public float Rate { get; set; }
        public float Amount { get; set; }
        public int LocationId { get; set; }

                public String UpdatedBy { get; set; }

    }

}