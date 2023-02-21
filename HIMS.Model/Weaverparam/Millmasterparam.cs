using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
  public  class Millmasterparam
    {
        public MillInsert MillInsert { get; set; }

        public MillUpdate MillUpdate { get; set; }
    }

    public class MillInsert
    {

        
         public int MillID { get; set; }
        public String MillName { get; set; }
      
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class MillUpdate
    {

        public String Operation { get; set; }
        public int MillID { get; set; }
        public String MillName { get; set; }

        public String UpdatedBy { get; set; }

    }

}
