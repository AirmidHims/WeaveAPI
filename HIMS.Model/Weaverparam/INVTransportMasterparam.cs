using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVTransportMasterparam
    {
        public InsertTransport InsertTransport { get; set; }

        public UpdateTransport UpdateTransport { get; set; }
    }

    public class InsertTransport
    {

      
        public int TransportID { get; set; }
        public String TransportName { get; set; }

        public String TransportCode { get; set; }
        public float TagaRate { get; set; }

        public float BagRate { get; set; }
        public float LoadedBeamRate { get; set; }
        public float EmptyBeamRate { get; set; }
        public float OtherRate { get; set; }
        public float CutePeiceRate { get; set; }
        public float RollRate { get; set; }
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class UpdateTransport
    {
       
        public String Operation { get; set; }

        public int TransportID { get; set; }
        public String TransportName { get; set; }

        public String TransportCode { get; set; }
        public int TagaRate { get; set; }

        public int BagRate { get; set; }
        public int LoadedBeamRate { get; set; }
        public int EmptyBeamRate { get; set; }
        public int OtherRate { get; set; }
        public int CutePeiceRate { get; set; }
        public int RollRate { get; set; }
        public String UpdatedBy { get; set; }

    }

}
