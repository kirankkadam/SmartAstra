using SmartAstra.Framework.Common;
using System;

namespace SmartAstra.Entities
{
    public class User : BaseEntityWithCreatedUpdatedDate
    {
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Status Status { get; set; }
        public string Password { get; set; }
        public bool ShouldChangePassword { get; set; }
        public DateTime PasswordUpdatedOn { get; set; }
    }
}
