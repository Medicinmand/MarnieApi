using MarnieWcf.Models;
using System.Data.Entity;

namespace MarnieWcf.DbAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}