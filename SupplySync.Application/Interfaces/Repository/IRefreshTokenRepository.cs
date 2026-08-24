using SupplySync.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Application.Interfaces.Repository
{
    public interface IRefreshTokenRepository
    {
        Task AddAsync(RefreshToken refreshToken,CancellationToken cancellationToken = default);

        Task<RefreshToken?> GetByTokenHashAsync( string tokenHash, CancellationToken cancellationToken = default);

        Task UpdateAsync( RefreshToken refreshToken, CancellationToken cancellationToken = default);
    }
}
