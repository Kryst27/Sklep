using CarWorkshop.Domain.Interfejsy;
using CarWorkshop.Infastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infastructure.Repository
{
    public class CarWorkshopRepository : ICarWorkShopRepository
    {
        public readonly CarWorkshopDbContext dbContext;
        public CarWorkshopRepository(CarWorkshopDbContext _dbcontext) 
        {
        
            dbContext = _dbcontext;
        }
        public async Task Create(Domain.Encje.CarWorkshop carWorkshop)
        {
            dbContext.Add(carWorkshop);
          await  dbContext.SaveChangesAsync();
        }

    }
}
