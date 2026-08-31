using SupplySync.Application.Interfaces;
using SupplySync.Application.Interfaces.Service.Login;
using SupplySync.Domain.Entities.Authentication.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Application.Services.Auth
{
    public class AuthService : IAuthService
    {

        private readonly IUserRepository _userRepository;
        //private readonly IPass

        public Task<LoginResponse> LoginAsync(LoginRequest request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
