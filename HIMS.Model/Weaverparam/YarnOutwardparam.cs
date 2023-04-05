using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class YarnOutwardparam
    {
        public InsertYarnOutward InsertYarnOutward { get; set; }

        public List<InsertYarnOutwardItemList> InsertYarnOutwardItemList { get; set; }

        public UpdateYarnOutward UpdateYarnOutward { get; set; }


        public List<UpdateYarnOutwardItemList> UpdateYarnOutwardItemList { get; set; }
    }

    public class InsertYarnOutward
    {


        public int YarnOutwardID { get; set; }

        public int EntryNo { get; set; }
        public DateTime EntryDate { get; set; }

        public String PONo { get; set; }
        public String ChallanNo { get; set; }

        public int PartyId { get; set; }
        public int SetNo { get; set; }
        public int QualityId { get; set; }

        public int TranferPartyId { get; set; }

        public int OWTypeId { get; set; }
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

    public class UpdateYarnOutward
    {

        public String Operation { get; set; }
        public int YarnOutwardID { get; set; }

        public string YarnOutwardCode { get; set; }
        public DateTime EntryDate { get; set; }

        public String PONo { get; set; }
        public String ChallanNo { get; set; }
       // public int AccountId { get; set; }
        public int PartyId { get; set; }
        public int SetNo { get; set; }
        public int QualityId { get; set; }

        public int TranferPartyId { get; set; }

        public int OWTypeId { get; set; }
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


    public class InsertYarnOutwardItemList
    {

        public int YarnOutListID { get; set; }

        public int YarnOutwardID { get; set; }

        
        public int YarnCount { get; set; }
        public int MillID { get; set; }

        public int Set { get; set; }

        public int ShadeId { get; set; }
        public int Bags { get; set; }
        public float BagWt { get; set; }
        public int Cones { get; set; }

        public float ConesWt { get; set; }
        public float TotalGrossWt { get; set; }
        public float TotalNetWt { get; set; }
        public String Category { get; set; }
        public String Scale { get; set; }
        
        public float Amount { get; set; }
        public int LocationId { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateYarnOutwardItemList
    {
        public String Operation { get; set; }
        public int YarnOutListID { get; set; }

        public int YarnOutwardID { get; set; }

       
        public int YarnCount { get; set; }
        public int MillID { get; set; }

        public int ShadeId { get; set; }
        public int Bags { get; set; }
        public float BagWt { get; set; }
        public int Cones { get; set; }

        public float ConesWt { get; set; }
        public float TotalGrossWt { get; set; }
        public float TotalNetWt { get; set; }
        public String Category { get; set; }
        public String Scale { get; set; }

        public float Amount { get; set; }
        public int LocationId { get; set; }

         public String UpdatedBy { get; set; }

    }

}