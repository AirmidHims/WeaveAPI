using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class Rolltypemasterparam
    {
        public InsertRollTypenmaster InsertRollTypenmaster { get; set; }

        public UpdateRollTypemaster UpdateRollTypemaster { get; set; }
    }
   

        public class InsertRollTypenmaster
    {
        public int RollTypeID { get; set; }
        public String RollType { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }

    public class UpdateRollTypemaster
    {
        public String Operation { get; set; }
        public int RollTypeID { get; set; }
        public String RollType { get; set; }
        public String UpdatedBy { get; set; }
    }

}
