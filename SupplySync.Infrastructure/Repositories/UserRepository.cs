using MongoDB.Driver;
using SupplySync.Application.Interfaces;
using SupplySync.Domain.Entities;
using SupplySync.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userCollection;

        public UserRepository(IMongoDbContext context)
        {
            _userCollection = context.Users;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
           return await _userCollection.Find(_ => true).ToListAsync();
        }
    }
}
