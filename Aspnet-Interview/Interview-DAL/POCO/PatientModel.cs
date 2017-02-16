using System;

namespace Interview_DAL.POCO
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatientId { get; set; }
        public DateTime DOB { get; set; }
        public int CountryId { get; set; }
        public string Diseases { get; set; }
        public string PhoneNumber { get; set; }
        public int BloodTypeId { get; set; }

    }
}