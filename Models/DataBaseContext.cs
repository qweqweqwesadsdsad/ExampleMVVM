using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.Entity;
using System.IO;

namespace WpfApp1.Models
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True")
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
