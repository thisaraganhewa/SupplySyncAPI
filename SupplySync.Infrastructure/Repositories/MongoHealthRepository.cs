using SupplySync.Application.Interfaces.Repository;
using SupplySync.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Infrastructure.Repositories
{
    class MongoHealthRepository : IMongoHealthRepository
    {

        private readonly IMongoDbContext mongoDbContext;

        public MongoHealthRepository(IMongoDbContext mongoDbContext)
        {
            this.mongoDbContext = mongoDbContext;
        }

        public async Task<bool> PingAsync()
        {
            try
            {
                await mongoDbContext.PingAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
