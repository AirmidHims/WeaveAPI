using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVBeamMasterparam
    {
        public InsertBeam InsertBeam { get; set; }

        public UpdateBeam UpdateBeam { get; set; }
    }

    public class InsertBeam
    {

      
        public int BeamID { get; set; }
        public int BeamNumber { get; set; }

       // public String TransportCode { get; set; }
        public int EmptyBeamWt { get; set; }

     
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class UpdateBeam
    {

        public String Operation { get; set; }

        public int BeamID { get; set; }
        public int BeamNumber { get; set; }

       // public String TransportCode { get; set; }
        public int EmptyBeamWt { get; set; }


        public String UpdatedBy { get; set; }


    }

}