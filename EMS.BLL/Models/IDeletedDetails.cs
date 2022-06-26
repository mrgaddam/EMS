using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Models
{
    public interface IDeletedDetails
    {
        int? DeletedBy { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
