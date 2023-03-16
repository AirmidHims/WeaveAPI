using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
  public  class BeamInwardparam
    {
        public InsertBeamInward InsertBeamInward { get; set; }

        public UpdateBeamInward UpdateBeamInward { get; set; }
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

}