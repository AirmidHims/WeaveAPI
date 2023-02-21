using HIMS.Common.Utility;
using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.IPD
{
   public class R_GRNReturn:GenericRepository,I_GRNReturn
    {

        public R_GRNReturn(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection
        }


        public bool Insert(GRNReturnparam1 GRNReturnparam1)
        {
           //hrow new NotImplementedException();

           // throw new NotImplementedException();

            var dic = GRNReturnparam1.InsertGRNReturn.ToDictionary();
            // dic.Remove("MLCId");
            ExecNonQueryProcWithOutSaveChanges("insert_GRNReturnDetails_1", dic);

            
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(GRNReturnparam1 GRNReturnparam)
        {
          //  throw new NotImplementedException();

            var dic = GRNReturnparam.UpdateGRNReturn.ToDictionary();
            // dic.Remove("MLCId");
            ExecNonQueryProcWithOutSaveChanges("insert_MLCInfo_1", dic);

            
            _unitofWork.SaveChanges();
            return true;
        }
    }



}
