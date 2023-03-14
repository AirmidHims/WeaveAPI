using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
   public class DesignMasterParam
    {

        public InsertDesign InsertDesign { get; set; }

        public UpdateDesign UpdateDesign { get; set; }
    }

    public class InsertDesign
    {

        public int DesignID { get; set; }
        public String DesignCode { get; set; }

        public String DesignName { get; set; }
        public String RSpace { get; set; }

        public String Reed { get; set; }
        public int QualityId { get; set; }
        public String Pick { get; set; }
        public int Waste { get; set; }
        public String HsnNo { get; set; }
        public String Width { get; set; }
        public float TotalEnds { get; set; }
        public float TotalExpWt { get; set; }
        public float TotalRepeatPick { get; set; }
        public float TotalDesignPick { get; set; }
        public float TotalExpGms { get; set; }
        public float TotalStandardGms { get; set; }

        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdateDesign
    {

        public String Operation { get; set; }
        public int DesignID { get; set; }
        public String DesignName { get; set; }
        public String RSpace { get; set; }

        public String Reed { get; set; }
        public int QualityId { get; set; }
        public String Pick { get; set; }
        public int Waste { get; set; }
        public String HsnNo { get; set; }
        public String Width { get; set; }
        public float TotalEnds { get; set; }
        public float TotalExpWt { get; set; }
        public float TotalRepeatPick { get; set; }
        public float TotalDesignPick { get; set; }
        public float TotalExpGms { get; set; }
        public float TotalStandardGms { get; set; }
        public String UpdatedBy { get; set; }

    }

}