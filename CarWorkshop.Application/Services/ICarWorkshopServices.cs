﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopServices
    {
        Task Create(Domain.Encje.CarWorkshop carWorkshop);
    }
}