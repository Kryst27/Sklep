using CarWorkshop.Infastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infastructure.Seeder
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopSeeder(CarWorkshopDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public async Task Seed() 
        {
            if ( await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.carWorkshops.Any())
                {
                    var Toyota = new Domain.Encje.CarWorkshop()
                    {
                        Name="Toyota ASO",
                        Description = "Autoryzowany serwis toyota",
                        ContactDetails = new Domain.Encje.CarWorkshopContactDetails()
                        {
                            City ="Gdańsk",
                            Street ="Grunwaldzka",
                            PostalCode="00-800",
                            PhoneNumber="5454564654646"
                        }

                    };
                    Toyota.EncodeName();
                    _dbContext.carWorkshops.Add(Toyota);
                   await _dbContext.SaveChangesAsync();
                }
            }
        
        }
    }
}
