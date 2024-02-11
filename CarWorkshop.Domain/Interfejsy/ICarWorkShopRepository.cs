using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Interfejsy
{
    public interface ICarWorkShopRepository
    {
        Task Create(Domain.Encje.CarWorkshop carWorkshop);
    }
}
