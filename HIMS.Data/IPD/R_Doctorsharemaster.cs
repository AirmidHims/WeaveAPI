using HIMS.Common.Utility;
using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.IPD
{
  public  class R_Doctorsharemaster :GenericRepository,I_Doctorsharemaster
    {
        public R_Doctorsharemaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

       
       

        public string Insert(Doctorsharemasterparam Doctorsharemasterparam)
        {
            // throw new NotImplementedException();


            var outputId = new SqlParameter
            {

                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@DocShareId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


            var dic = Doctorsharemasterparam.DoctorshareheaderInsert.ToDictionary();
            dic.Remove("DocShareId");
            var Id = ExecNonQueryProcWithOutSaveChanges("insert_DoctorShareHeader_1", dic, outputId);


            var dic1 = Doctorsharemasterparam.DoctorshareheaderInsert.ToDictionary();
            //  dic.Remove("MaterialConsumptionId");
            var Id1 = ExecNonQueryProcWithOutSaveChanges("Insert_DoctorShareMaster_1", dic1);

            _unitofWork.SaveChanges();

            return Id;
        }
    }
}
