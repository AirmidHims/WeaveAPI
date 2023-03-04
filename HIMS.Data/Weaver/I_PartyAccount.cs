using HIMS.Model.Weaverparam;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Weaver
{
   public interface I_PartyAccount
    {
        public String Insert(PartyAccountParam PartyAccountParam);

        public bool Update(PartyAccountParam PartyAccountParam);
    }
}
