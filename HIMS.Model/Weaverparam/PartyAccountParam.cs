using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Weaverparam
{
  public  class PartyAccountParam
    {
        public InsertPartyAccount InsertPartyAccount { get; set; }

        public UpdatePartyAccount UpdatePartyAccount { get; set; }
    }

    public class InsertPartyAccount
    {

        public int AccountId { get; set; }
        public String AccountType { get; set; }

        public String Name { get; set; }
        public String ContactPerson { get; set; }

        public long ContactNo { get; set;}
        public String EmailAddress { get; set; }
        public String Website { get; set; }
        public String BussAddress { get; set; }
        public String City { get; set; }
        public String District { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public int PinCode { get; set; }
        public String GSTN { get; set; }
        public String PAN { get; set; }
        public String CIN { get; set; }

        public String CreditDebit { get; set; }

        public float OpeningBalance { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }

    }

    public class UpdatePartyAccount
    {
      
        public String Operation { get; set; }

        public int AccountId { get; set; }
        public String AccountType { get; set; }

        public String Name { get; set; }
        public String ContactPerson { get; set; }

        public long ContactNo { get; set; }
        public String EmailAddress { get; set; }
        public String Website { get; set; }
        public String BussAddress { get; set; }
        public String City { get; set; }
        public String District { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public int PinCode { get; set; }
        public String GSTN { get; set; }
        public String PAN { get; set; }
        public String CIN { get; set; }

        public String CreditDebit { get; set; }

        public float OpeningBalance { get; set; }
        public String UpdatedBy { get; set; }

    }

}