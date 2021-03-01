using LockersHub.BL.BusinessLogic;
using LockersHub.BL.BusinessLogic.Interfaces;
using LockersHub.DALS.Infrastructure;
using LockersHub.DALS.Infrastructure.Interfaces;
using LockersHub.DALS.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockersHub.BL.Infrastructure
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBLLDependenciesLibraries(this IServiceCollection services)
        {

            services.AddEntityFrameworkSqlServer();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperWebProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ILockersBL, LockersBL>();
            services.AddScoped<ISetupsBL, SetupsBL>();
            services.AddScoped<IUsersBL, UsersBL>();

            return services;
        }
    }
}
