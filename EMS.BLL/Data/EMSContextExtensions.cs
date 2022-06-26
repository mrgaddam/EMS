using EMS.BLL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Data
{
    public partial class EMSContext : DbContext
    {
        public IConfiguration Configuration { get; }
        public EMSContext(DbContextOptions<EMSContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnection sqlConnection = new SqlConnection();
            if (Configuration != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                sqlConnection.ConnectionString = Configuration.GetConnectionString("ETSDBConnection");
                optionsBuilder.UseSqlServer(sqlConnection);
            }
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            HandleModifedDetails();
            HandleCreatedDetails();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.DetectChanges();
            HandleModifedDetails();
            HandleCreatedDetails();
            return base.SaveChangesAsync(cancellationToken);
        }


        private void HandleCreatedDetails()
        {
            var markedAsModified = ChangeTracker.Entries().Where(x =>
            x.State == EntityState.Modified ||
            x.State == EntityState.Deleted);

            foreach (var item in markedAsModified)
            {
                if (item.Entity is IModifiedDetails entity)
                {
                    item.Property("CreatedBy").IsModified = false;
                    item.Property("CreatedDate").IsModified = false;
                }
            }

            var markedAsAdded = ChangeTracker.Entries().Where(x =>
            x.State == EntityState.Added);

            foreach (var item in markedAsAdded)
            {
                if (item.Entity is ICreatedDetails entity)
                {
                    entity.CreatedBy = 99;
                    entity.CreatedDate = DateTime.Now;
                }
            }
        }

        private void HandleModifedDetails()
        {
            var markedAsModified = ChangeTracker.Entries().Where(x =>
            x.State == EntityState.Modified ||
            x.State == EntityState.Deleted);

            foreach (var item in markedAsModified)
            {
                if (item.Entity is IModifiedDetails entity)
                {
                    entity.ModifiedBy = 1;
                    entity.ModifiedDate = DateTime.Now;
                    item.Property("CreatedBy").IsModified = false;
                    item.Property("CreatedDate").IsModified = false;
                }
            }

        }
    }
}
