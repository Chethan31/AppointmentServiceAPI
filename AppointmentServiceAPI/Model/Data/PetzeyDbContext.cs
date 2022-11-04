using Microsoft.EntityFrameworkCore;
using AppointmentServiceAPI.Model.Entities;

namespace AppointmentServiceAPI.Model.Data
{
    public class PetzeyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Petzey2022DB;Integrated Security=True");
        }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
