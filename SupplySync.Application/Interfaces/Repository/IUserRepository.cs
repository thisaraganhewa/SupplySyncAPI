using SupplySync.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SupplySync.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
    }
}
