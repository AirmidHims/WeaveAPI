using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class INVQualitymasterparam
    {
        public InsertQualitymaster InsertQualitymaster { get; set; }

        public UpdatetQualitymaster UpdatetQualitymaster { get; set; }
    }

    public class InsertQualitymaster
    {
        
           
        public int QualityId { get; set; }
        public String QualityName { get; set; }
        public String QualityCode { get; set; }
        public int AccountId { get; set; }

        public int Waste { get; set; }
        public String Construction { get; set; }
        public int WidthInch { get; set; }

      
        public int WidthCms { get; set; }

        public int RsInch { get; set; }
        public int RsCms { get; set; }
        public int ReedInch { get; set; }
        public int ReedCms { get; set; }


        public int PickInch { get; set; }
        public int PickCms { get; set; }
        public String WarpSort1 { get; set; }
        public String WarpSort2 { get; set; }

        public String WarpSort3 { get; set; }
        public String WeftSort1 { get; set; }
        public String WeftSort2 { get; set; }
        public String WeftSort3 { get; set; }

        public String Type { get; set; }
        public bool IsDesign { get; set; }
        public String Remark { get; set; }
        public String CreatedBy { get; set; }

         public String UpdatedBy { get; set; }

    }

    public class UpdatetQualitymaster
    {

        public String Operation { get; set; }
        public int QualityId { get; set; }
        public String QualityName { get; set; }
        
        public int AccountId { get; set; }

        public int Waste { get; set; }
        public String Construction { get; set; }
        public int WidthInch { get; set; }


        public int WidthCms { get; set; }

        public int RsInch { get; set; }
        public int RsCms { get; set; }
        public int ReedInch { get; set; }
        public int ReedCms { get; set; }


        public int PickInch { get; set; }
        public int PickCms { get; set; }
        public String WarpSort1 { get; set; }
        public String WarpSort2 { get; set; }

        public String WarpSort3 { get; set; }
        public String WeftSort1 { get; set; }
        public String WeftSort2 { get; set; }
        public String WeftSort3 { get; set; }

        public String Type { get; set; }
        public bool IsDesign { get; set; }
        public String Remark { get; set; }
        public String UpdatedBy { get; set; }

    }

}