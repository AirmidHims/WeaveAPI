using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
  public  class BeamInwardparam
    {
        public InsertBeamInward InsertBeamInward { get; set; }
        public List<InsertBeamInwardItemList> InsertBeamInwardItemList { get; set; }
        public UpdateBeamInward UpdateBeamInward { get; set; }

    

        public List<UpdateBeamInwardItemList> UpdateBeamInwardItemList { get; set; }


    }

    public class InsertBeamInward
    {
              
 
        
        public int BeamInwardID { get; set; }


        public DateTime BeamInwardDate { get; set; }
        public DateTime BeamInwardTime { get; set; }
       
        public string ChallanNo { get; set; }

        public DateTime ChallanDate { get; set; }

        public int PartyId { get; set; }

        public int SizingId { get; set; }
        public String PartySetNo { get; set; }
        public int ContractBookingId { get; set; }
        public DateTime ContractDate { get; set; }

        public float ContractMeters { get; set; }
        public float CurrentMeters { get; set; }
        public float PreviousMeters { get; set; }
        public float BalanceMeters { get; set; }
        public float TotalCuts { get; set; }
        public float TotalBeamMeters { get; set; }
        public float TotalProductionMeters { get; set; }
        public int TotalWeftCons { get; set; }
        public String Remark { get; set; }
        public int TransportID { get; set; }
        
         
        public String VehicleNo { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateBeamInward
    {

        public String Operation { get; set; }
        public int BeamInwardID { get; set; }


        public DateTime BeamInwardDate { get; set; }
        public DateTime BeamInwardTime { get; set; }

        public string ChallanNo { get; set; }

        public DateTime ChallanDate { get; set; }

        public int PartyId { get; set; }

        public int SizingId { get; set; }
        public String PartySetNo { get; set; }
        public int ContractBookingId { get; set; }
        public DateTime ContractDate { get; set; }

        public float ContractMeters { get; set; }
        public float CurrentMeters { get; set; }
        public float PreviousMeters { get; set; }
        public float BalanceMeters { get; set; }
        public float TotalCuts { get; set; }
        public float TotalBeamMeters { get; set; }
        public float TotalProductionMeters { get; set; }
        public int TotalWeftCons { get; set; }
        public String Remark { get; set; }
        public int TransportID { get; set; }


        public String VehicleNo { get; set; }


        public String UpdatedBy { get; set; }

    }

   

         public class InsertBeamInwardItemList
    {

           public int BeamInListID { get; set; }

            public int BeamInwardId { get; set; }
        public int RoundNo { get; set; }

        public int BeamSrNo { get; set; }

        public int SizeSetNo { get; set; }

        public int SetBeamNo { get; set; }
       
        public int QualityId { get; set; }
        public int DesignId { get; set; }
        public int FlangeNo { get; set; }
        public String Ends { get; set; }

        public String  RSpace { get; set; }
        public String Reed { get; set; }
        public float DesignPick { get; set; }
        public float LoomPick { get; set; }


        public float Lasa { get; set; }
        public String YardMeter { get; set; }
        public float Cuts { get; set; }
        public float BeamWt { get; set; }
        public float BeamMeter { get; set; }
        public float Shrink { get; set; }
        public float ProdMeter { get; set; }


        public float ReqMeter { get; set; }
        public float ReqFolds { get; set; }
        public float WeftCons { get; set; }
        public String JobPick { get; set; }
        public float RatePerMeter { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateBeamInwardItemList
    {

        public String Operation { get; set; }
        public int BeamInListID { get; set; }


        public int BeamInwardId { get; set; }
        public int RoundNo { get; set; }

        public int BeamSrNo { get; set; }

        public int SizeSetNo { get; set; }

        public int SetBeamNo { get; set; }

        public int QualityId { get; set; }
        public int DesignId { get; set; }
        public int FlangeNo { get; set; }
        public String Ends { get; set; }

        public String RSpace { get; set; }
        public String Reed { get; set; }
        public float DesignPick { get; set; }
        public float LoomPick { get; set; }


        public float Lasa { get; set; }
        public String YardMeter { get; set; }
        public float Cuts { get; set; }
        public float BeamWt { get; set; }
        public float BeamMeter { get; set; }
        public float Shrink { get; set; }
        public float ProdMeter { get; set; }


        public float ReqMeter { get; set; }
        public float ReqFolds { get; set; }
        public float WeftCons { get; set; }
        public String JobPick { get; set; }
        public float RatePerMeter { get; set; }


        public String UpdatedBy { get; set; }

    }

}