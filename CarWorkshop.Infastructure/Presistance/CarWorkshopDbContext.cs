using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infastructure.Presistance
{
   public class CarWorkshopDbContext:DbContext
   {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options): base(options) { }

       
        public DbSet<CarWorkshop.Domain.Encje.CarWorkshop> carWorkshops { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=KRYSTIAN\\;Database=CarWorkshop;Trusted_Connection=True;Encrypt=False;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Encje.CarWorkshop>().OwnsOne(c => c.ContactDetails);
        }
    }
}
