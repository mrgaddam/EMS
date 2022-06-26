using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.ViewModels
{
    public class LoginViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string MobileNumber { get; set; }
        public string RoleName { get; set; }
        public string UserToken { get; set; }
    }
}
