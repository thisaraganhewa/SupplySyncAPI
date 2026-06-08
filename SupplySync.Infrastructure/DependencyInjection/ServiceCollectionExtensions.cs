using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using SupplySync.Application.Interfaces;
using SupplySync.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IMongoClient>(
                 sp =>
                 {
                     var connectionString = configuration.GetConnectionString("Mongo");

                     return new MongoClient(connectionString);
                 }
                );

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
