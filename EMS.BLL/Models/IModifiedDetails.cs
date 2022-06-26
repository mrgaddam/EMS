using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Models
{
    public interface IModifiedDetails
    {
        int? ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }

    }
}
