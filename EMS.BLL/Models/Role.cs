using System.ComponentModel.DataAnnotations;

namespace EMS.BLL.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
