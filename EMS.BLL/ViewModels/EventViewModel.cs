
namespace EMS.BLL.ViewModels
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? EventDescription { get; set; }
        public DateTime EventStartDateTime { get; set; }
        public DateTime EventEndDateTime { get; set; }
        public string? EventPlace { get; set; }
        public string? EventTypeName { get; set; }
        public decimal? TicketPrice { get; set; }
        public string? OrganisationDescription { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPersonNumber { get; set; }
    }
}
