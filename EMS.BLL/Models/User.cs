using System.ComponentModel.DataAnnotations;s

namespace EMS.BLL.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string MobileNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool UserStatus { get; set; }
    }
}
