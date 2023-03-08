using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class ContractBookingparam
    {

        public InsertContractBooking InsertContractBooking { get; set; }

        public UpdateContractBooking UpdateContractBooking { get; set; }
    }

    public class InsertContractBooking
    {
      
        public int ContractBookingID { get; set; }
        public String BookingNo { get; set; }

        public DateTime BookingDate { get; set; }
        public int PartyID { get; set; }

        public int SizingID { get; set; }

        public int BrokerID { get; set; }
        public int Brokerage { get; set; }
        public int QualityId { get; set; }
        public int DesignId { get; set; }
        public int TotalBeams { get; set; }
        public String Pick { get; set; }
        public float JobRate { get; set; }
        public float TotalMeter { get; set; }
        public DateTime CompleteDate { get; set; }

        public String PaymentTerms { get; set; }
        public String Remark { get; set; }
      
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateContractBooking
    {
        public String Operation { get; set; }
        public int ContractBookingID { get; set; }
        public String BookingNo { get; set; }

        public DateTime BookingDate { get; set; }
        public int PartyID { get; set; }

        public int SizingID { get; set; }
        public int BrokerID { get; set; }
        public float Brokerage { get; set; }
        public int QualityId { get; set; }
        public int DesignId { get; set; }
        public int TotalBeams { get; set; }
        public String Pick { get; set; }
        public float JobRate { get; set; }
        public float TotalMeter { get; set; }
        public DateTime CompleteDate { get; set; }

        public String PaymentTerms { get; set; }
        public String Remark { get; set; }

        public String UpdatedBy { get; set; }

    }

}
