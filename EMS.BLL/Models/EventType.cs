using System.ComponentModel.DataAnnotations;

namespace EMS.BLL.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
    }
}
