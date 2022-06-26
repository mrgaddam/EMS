using EMS.BLL.Data;

namespace EMS.BLL.Implementation
{
    public class BaseManager
    {
        protected EMSContext Context { get; }

        public BaseManager(EMSContext context)
        {
            Context = context;
        }
    }
}
