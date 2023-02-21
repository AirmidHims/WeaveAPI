using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class ItemMasterparam
    {

        public ItemInsert ItemInsert { get; set; }

        public ItemUpdate ItemUpdate { get; set; }
    }

    public class ItemInsert
    {

        public int ItemID { get; set; }
        public String ItemName { get; set; }

        public String ItemMaker { get; set; }
        public String ItemCategory { get; set; }

        public String ItemUnit { get; set; }
        public String ItemPartNumber { get; set; }

        public int ItemRate { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }

    public class ItemUpdate
    {

        public String Operation { get; set; }
        public int ItemID { get; set; }
        public String ItemName { get; set; }

        public String ItemMaker { get; set; }
        public String ItemCategory { get; set; }

        public String ItemUnit { get; set; }
        public String ItemPartNumber { get; set; }

        public int ItemRate { get; set; }
        
        public String UpdatedBy { get; set; }
    }
}



