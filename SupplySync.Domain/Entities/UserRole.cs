using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    class UserRole
    {
        public string Id { get; private set; } = null!;

        public string UserId { get; private set; } = null!;

        public string RoleId { get; private set; } = null!;

        public DateTime AssignedAt { get; private set; }

        public string? AssignedBy { get; private set; }

        public bool IsActive { get; private set; }
    }
}
