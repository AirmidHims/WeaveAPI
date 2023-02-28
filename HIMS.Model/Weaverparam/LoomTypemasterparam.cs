using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class LoomTypemasterparam
    {
        public InsertLoomTypenmaster InsertLoomTypenmaster { get; set; }

        public UpdateLoomTypemaster UpdateLoomTypemaster { get; set; }
    }

    public class InsertLoomTypenmaster
    {
        public int LoomTypeID { get; set; }
        public String LoomType { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }

    public class UpdateLoomTypemaster
    {
        public String Operation { get; set; }
        public int LoomTypeID { get; set; }
        public String LoomType { get; set; }
        public String UpdatedBy { get; set; }
    }

}
