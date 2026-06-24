using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using SupplySync.Application.Interfaces;
using SupplySync.Infrastructure.Configuration;
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

            //services.AddScoped<IMongoDbContext, Mongo>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
