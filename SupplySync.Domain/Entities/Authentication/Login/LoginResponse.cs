using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities.Authentication.Login
{
    public class LoginResponse
    {
        public string AccessToken { get; set; } = null!;

        public string RefreshToken { get; set; } = null!;

        public DateTime AccessTokenExpiresAt { get; set; }

        public UserResponse User { get; set; } = null!;
    }
}
