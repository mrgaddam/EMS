using EMS.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.BLL.Data
{

    public partial class EMSContext : DbContext
    {

        public DbSet<Event> Events { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventOrganization> EventOrganizations { get; set; }
    }
}
