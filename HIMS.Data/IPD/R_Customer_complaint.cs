using HIMS.Common.Utility;
using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.IPD
{
    public class R_Customer_complaint :GenericRepository,I_Customer_complaint
    {
          public R_Customer_complaint(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public bool Insert(Customercomplaintparam Customercomplaintparam)
        {
            //throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ComplaintNo",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = Customercomplaintparam.CustomerComplaintInsert.ToDictionary();
            disc.Remove("ComplaintNo");

            var Id = ExecNonQueryProcWithOutSaveChanges("insert_Customercomplaint_details", disc, outputId);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(Customercomplaintparam Customercomplaintparam)
        {
            //throw new NotImplementedException();

            var disc = Customercomplaintparam.CustomerComplaintUpdate.ToDictionary();

            var Id = ExecNonQueryProcWithOutSaveChanges("Update_Customercomplaint_details", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
