using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVLoommasterparam
    {
        public InsertLoommaster InsertLoommaster { get; set; }

        public UpdatetLoommaster UpdatetLoommaster { get; set; }
    }

    public class InsertLoommaster
    {
           

        public int LoomId { get; set; }
       // public String LoomCode { get; set; }
        public String CompanyName { get; set; }
        public String LoomNo { get; set; }

        public int RPM { get; set; }
        public String MfgCompany { get; set; }
        public String MfgSrno { get; set; }
        public int LoomTypeId { get; set; }

        public String StdEfficiency { get; set; }
        public String ReadingFactor { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }


    }

    public class UpdatetLoommaster
    {
       

          public String Operation { get; set; }
        public int LoomId { get; set; }
       
        public String CompanyName { get; set; }
        public String LoomNo { get; set; }

        public int RPM { get; set; }
        public String MfgCompany { get; set; }
        public String MfgSrno { get; set; }
        public int LoomTypeId { get; set; }

        public String StdEfficiency { get; set; }
        public String ReadingFactor { get; set; }
        
        public String UpdatedBy { get; set; }

    }

}
