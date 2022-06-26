using System.ComponentModel.DataAnnotations;

namespace EMS.BLL.Models
{
    public class EventOrganization
    {
        [Key]
        public int EventOrganizedById { get; set; }
        public string OrganisationDescription { get; set; }
    }
}
