using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
  public  class INVDefectMasterparam
    {
        public InsertDefect InsertDefect { get; set; }

        public UpdateDefect UpdateDefect { get; set; }
    }

    public class InsertDefect
    {

      
        public int DefectID { get; set; }
        public String DefectName { get; set; }

        public String EntNo { get; set; }
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class UpdateDefect
    {

        public String Operation { get; set; }

        public int DefectID { get; set; }

        public String EntNo { get; set; }
        public String DefectName { get; set; }

         public String UpdatedBy { get; set; }


    }

}