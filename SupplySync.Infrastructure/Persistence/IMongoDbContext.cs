using MongoDB.Driver;
using SupplySync.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Infrastructure.Persistence
{
    interface IMongoDbContext
    {
        IMongoCollection<User> Users { get; }
    }
}
