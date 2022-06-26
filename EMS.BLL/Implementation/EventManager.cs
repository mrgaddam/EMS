using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS.BLL.Data.Context;
using EMS.BLL.Data.Dto;
using EMS.BLL.Interface;
namespace EMS.BLL.Implementation
{
    public class EventManager :  BaseManager, IEventManager
    {
        public EventManager(ETSContext Context) :base(Context)
        {
        }

        public async Task<IEnumerable<EventViewModel>> GetAllEventDetails()
        {
          return await (from e in Context.Events
                             join et in Context.EventTypes on e.EventTypeId equals et.EventTypeId
                             join er in Context.EventOrganizations on e.EventOrganisedById equals er.EventOrganizedById
                             select new EventDto
                             {
                                 EventId = e.EventId,
                                 EventName = e.EventName,
                                 EventDescription = e.EventDescription,
                                 EventStartDateTime = e.EventStartDateTime,
                                 EventEndDateTime = e.EventEndDateTime,
                                 EventPlace = e.EventPlace,
                                 EventTypeName = et.EventTypeName,
                                 TicketPrice =e.TicketPrice,
                                 OrganisationDescription = er.OrganisationDescription,
                                 ContactPerson = e.ContactPerson,
                                 ContactPersonNumber = e.ContactPersonNumber
                             }).OrderBy(X=>X.EventPlace).ToListAsync();            
        }
    }
}
