using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Context
{
    internal class EnterPriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source =.;Database= EnterPrise; Login= Omar; Password=1234");
            optionsBuilder.UseSqlServer("Server = .;Database= EnterPrise;Trusted_Connection= True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
