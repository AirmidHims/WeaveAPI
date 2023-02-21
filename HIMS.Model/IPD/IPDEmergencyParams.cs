using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.IPD
{
   public  class IPDEmergencyParams
    {
        public IPDEmergencyRegInsert IPDEmergencyRegInsert { get; set; }
        public IPDEmergencyAdv IPDEmergencyAdv { get; set; }

    }

    public class IPDEmergencyAdv
    {
        public int BedId { get; set; }
    }

    public class IPDEmergencyRegInsert
    {
        public long RegId { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime RegTime { get; set; }
        public long PrefixId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public long GenderID { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }

        public long AddedBy { get; set; }
        public long UpdatedBy { get; set; }

        public string AgeYear { get; set; }
        public string AgeMonth { get; set; }
        public string AgeDay { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public long MaritalStatusId { get; set; }
        public bool IsCharity { get; set; }
        //  public string RegPrefix { get; set; }
        public long ReligionId { get; set; }
        public long AreaId { get; set; }
        //  public long VillageId { get; set; }
        public bool IsSeniorCitizen { get; set; }

        // public int VillageId { get; set; }
        // public int TalukaId { get; set; }
        // public float PatientWeight { get; set; }
        //  public string AreaName { get; set; }
        public string AadharCardNo { get; set; }
        public string PanCardNo { get; set; }
    }
}

