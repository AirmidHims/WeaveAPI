using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
    public class Yarnmasterparam
    {
        public YarmInsert YarmInsert { get; set; }

        public YarmUpdate YarmUpdate { get; set; }
    }

    public class YarmInsert
    {
        public int yID { get; set; }
        public String yName { get; set; }
        public int yCount { get; set; }
        public String yPly { get; set; }
        public String yType { get; set; }
        public String yBlend { get; set; }
        public int yActualCount { get; set; }
        public int yDenierCount { get; set; }
       
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

      
    }


    public class YarmUpdate
    {

        public String Operation { get; set; }
        public int yID { get; set; }
        public String yName { get; set; }
         public int yCount { get; set; }
        public String yPly { get; set; }
        public String yType { get; set; }
        public String yBlend { get; set; }
        public int yActualCount { get; set; }
        public int yDenierCount { get; set; }
       
        public String UpdatedBy { get; set; }

    }

}
