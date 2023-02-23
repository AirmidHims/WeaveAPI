using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVLocationmasterparam
    {
        public InsertLocationmaster InsertLocationmaster { get; set; }

        public UpdateLocationmaster UpdateLocationmaster { get; set; }
    }

    public class InsertLocationmaster
    {


        public int LocationID { get; set; }
        public String LocationName { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }


    }

    public class UpdateLocationmaster
    {

        public String Operation { get; set; }
        public int LocationID { get; set; }
        public String LocationName { get; set; }
        public String UpdatedBy { get; set; }


    }

}