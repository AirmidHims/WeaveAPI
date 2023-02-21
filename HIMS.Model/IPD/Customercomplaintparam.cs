using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.IPD
{
   public class Customercomplaintparam
    {
        public CustomerComplaintInsert CustomerComplaintInsert { get; set; }

        public CustomerComplaintUpdate CustomerComplaintUpdate { get; set; }

    }


    public class CustomerComplaintInsert
    {

        public long ComplaintNo { get; set; }
        public String UserName { get; set; }
        public DateTime ComplaintDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ResolutionDate { get; set; }
        public String Address { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public string Complaintdescription { get; set; }
        public string AssignTo { get; set; }
        public string Status { get; set; }
        public bool Furtheractionrequired { get; set; }
      
    }

    public class CustomerComplaintUpdate
    {

        public long ComplaintNo { get; set; }
        public String UserName { get; set; }
        public DateTime ComplaintDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ResolutionDate { get; set; }
        public String Address { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public string Complaintdescription { get; set; }
        public string AssignTo { get; set; }
        public string Status { get; set; }
        public bool Furtheractionrequired { get; set; }

    }
}

