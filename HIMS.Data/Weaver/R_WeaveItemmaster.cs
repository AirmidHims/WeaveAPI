using HIMS.Common.Utility;
using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Weaver
{
    public class R_WeaveItemmaster : GenericRepository, I_WeaveItemmaster
    {

        public R_WeaveItemmaster(IUnitofWork unitofWork) : base(unitofWork)
        {

        }
        public string Insert(ItemMasterparam ItemMasterparam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ItemID",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = ItemMasterparam.ItemInsert.ToDictionary();
            disc.Remove("ItemID");
            var id = ExecNonQueryProcWithOutSaveChanges("Insert_ItemMaster", disc, outputId1);

            _unitofWork.SaveChanges();
            return (id);

        }

        public bool Update(ItemMasterparam ItemMasterparam)
        {
            //throw new NotImplementedException();

            var disc = ItemMasterparam.ItemUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Upd_Del_ItemMaster", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
