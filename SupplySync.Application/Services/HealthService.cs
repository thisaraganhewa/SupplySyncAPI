using SupplySync.Application.Interfaces.Repository;
using SupplySync.Application.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Application.Services
{
     public class HealthService : IHealthService
    {
        private readonly IMongoHealthRepository mongoHealthRepository;

        public HealthService(IMongoHealthRepository mongoHealthRepository)
        {
            this.mongoHealthRepository = mongoHealthRepository;
        }

        public async Task<bool> PingAsync()
        {
            return await mongoHealthRepository.PingAsync();
        }
    }
}
