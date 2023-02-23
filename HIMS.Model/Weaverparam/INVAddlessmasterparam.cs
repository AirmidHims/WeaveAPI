using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVAddlessmasterparam
    {

        public InsertAddless InsertAddless { get; set; }

        public UpdateAddless UpdateAddless { get; set; }
    }

    public class InsertAddless
    {

      
        public int AddLessID { get; set; }
        public String AddLessName { get; set; }

        public String StdEfficiency { get; set; }
        public String ReadingFactor { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateAddless
    {

        public String Operation { get; set; }
        public int AddLessID { get; set; }
        public String AddLessName { get; set; }

        public String StdEfficiency { get; set; }
        public String ReadingFactor { get; set; }

        public String UpdatedBy { get; set; }

    }

}
