using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;
using System.Collections.Generic;

namespace MyLeasing.Web.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        public DbSet<Owner> Owners { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
