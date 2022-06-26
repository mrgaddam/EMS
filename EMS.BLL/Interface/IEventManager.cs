using EMS.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Interface
{
    public interface IEventManager
    {
        Task<IEnumerable<EventViewModel>> GetAllEventDetails();
    }
}
