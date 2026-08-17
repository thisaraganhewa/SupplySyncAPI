using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    public class RefreshToken
    {
        public string Id { get; private set; } = null!;

        public string UserId { get; private set; } = null!;

        public string TokenHash { get; private set; } = null!;

        public DateTime ExpiresAt { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime? RevokedAt { get; private set; }

        public bool IsRevoked => RevokedAt.HasValue;
    }
}
