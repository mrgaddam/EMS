using System.ComponentModel.DataAnnotations;
namespace EMS.BLL.Models
{
    public partial class Event
    {

        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventStartDateTime { get; set; }
        public DateTime EventEndDateTime { get; set; }
        public string EventPlace { get; set; }
        public int EventTypeId { get; set; }  //free or Paid
        public decimal? TicketPrice { get; set; }
        public int EventOrganisedById { get; set; } //Individual or Company
        public string ContactPerson { get; set; }
        public string ContactPersonNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool EventStatus { get; set; }
        public DateTime? DeActivatedDate { get; set; }
    }
}
