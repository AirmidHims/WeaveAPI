using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class Shademasterparam
    {
        public ShadeInsert ShadeInsert { get; set; }

        public ShadeUpdate ShadeUpdate { get; set; }
    }

    public class ShadeInsert
    {
       
        public int shadeID { get; set; }
        public String shadeNumber { get; set; }
        public String shadeColour { get; set; }
       
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }


    }


    public class ShadeUpdate
    {

        public String Operation {get;set;}
        public int shadeID { get; set; }
        public String shadeNumber { get; set; }
        public String shadeColour { get; set; }

        public String UpdatedBy { get; set; }

    }

}
