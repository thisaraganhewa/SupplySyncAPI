using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Application.Interfaces.Repository
{
    public interface IMongoHealthRepository
    {
        Task<bool> PingAsync();
    }
}
