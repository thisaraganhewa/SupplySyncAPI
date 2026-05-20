using SupplySync.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Application.Interfaces.Service
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
    }
}
