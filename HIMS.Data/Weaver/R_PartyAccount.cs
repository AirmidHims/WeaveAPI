using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
  public  class R_PartyAccount:GenericRepository,I_PartyAccount
    {
        public R_PartyAccount(IUnitofWork unitofWork) : base(unitofWork)
        {

        }

        public String Insert(PartyAccountParam PartyAccountParam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@AccountId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = PartyAccountParam.InsertPartyAccount.ToDictionary();
            disc.Remove("AccountId");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_AccountMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);
        }

        public bool Update(PartyAccountParam PartyAccountParam)
        {
            //throw new NotImplementedException();
            var disc = PartyAccountParam.UpdatePartyAccount.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_AccountMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
