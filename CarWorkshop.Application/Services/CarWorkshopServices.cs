using CarWorkshop.Domain.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Services
{
    internal class CarWorkshopServices:ICarWorkshopServices
    {
        private readonly ICarWorkShopRepository _carWorkShopRepository;
        public CarWorkshopServices(ICarWorkShopRepository carWorkShop) 
        {
            _carWorkShopRepository = carWorkShop;
        }
        public async Task Create(Domain.Encje.CarWorkshop carWorkshop)
        {
            carWorkshop.EncodeName();
          await   _carWorkShopRepository.Create(carWorkshop);
        }
    }
}
