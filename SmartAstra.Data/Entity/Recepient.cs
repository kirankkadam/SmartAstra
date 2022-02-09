using System;

namespace SmartAstra.Data.Entity
{
    public class Recepient : BaseEntityWithCreatedUpdatedInfo
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string FacebookId { get; set; }
    }
}
