
﻿using CarWorkshop.Domain.Interfejsy;
using CarWorkshop.Infastructure.Presistance;
using CarWorkshop.Infastructure.Repository;

﻿using CarWorkshop.Infastructure.Presistance;

using CarWorkshop.Infastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infastructure.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CarWorkshop")));
            services.AddScoped<CarWorkshopSeeder>();

            services.AddScoped<ICarWorkShopRepository, CarWorkshopRepository>();


        }
    }
}
