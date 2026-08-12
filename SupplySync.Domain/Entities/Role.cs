using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    class Role
    {
        public string Id { get; private set; } = null!;

        public string Name { get; private set; } = null!;

        public string Description { get; private set; } = null!;

        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}
