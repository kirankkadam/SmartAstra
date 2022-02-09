using System;

namespace SmartAstra.Data.Entity
{
    public class User : BaseEntityWithCreatedUpdatedInfo
    {
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public bool ShouldChangePassword { get; set; }
        public DateTime PasswordUpdatedOn { get; set; }
    }
}
