using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Models
{
    public interface ICreatedDetails
    {
        int CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
