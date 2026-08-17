using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    public class Permission
    {
        public string Id { get; private set; } = null!;

        public string Code { get; private set; } = null!;

        public string Name { get; private set; } = null!;

        public string Description { get; private set; } = null!;

        public bool IsActive { get; private set; }
    }
}
