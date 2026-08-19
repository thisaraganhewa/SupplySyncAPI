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

        Task<User?> GetEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<User?> GetBuIdAsync(string buId, CancellationToken cancellationToken = default);

        Task AddAsync(User user, CancellationToken cancellation = default);
        Task UpdateAsync(User user, CancellationToken cancellation = default);
    }
}
