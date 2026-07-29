using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using SupplySync.Application.Interfaces;
using SupplySync.Application.Interfaces.Repository;
using SupplySync.Application.Interfaces.Service;
using SupplySync.Application.Services;
using SupplySync.Infrastructure.Configuration;
using SupplySync.Infrastructure.Persistence;
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
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<MongoDbSettings>(configuration.GetSection("Mongo"));

            services.AddSingleton<IMongoClient>(
                sp => 
                { 
                    var settings = configuration.GetSection("Mongo").Get<MongoDbSettings>();
                    return new MongoClient(settings.ConnectionString);
                }
            );

            services.AddScoped<IMongoDbContext, MongoDbContext>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMongoHealthRepository, MongoHealthRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHealthService, HealthService>();

            return services;
        }
    }
}
