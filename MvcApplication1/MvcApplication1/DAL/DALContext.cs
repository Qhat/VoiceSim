using MvcApplication1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcApplication1.DAL
{
    public class DALContext : DbContext
    {
        public DALContext()
            : base("DALContext")
        { }

        public DbSet<Person> People { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}