using Domain.Entities.Common;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }
        public string UserRole { get; set; }
        //public string Phone { get; set; }
    }
}
