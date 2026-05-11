using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    class User
    {
        [BsonId]
        public string Id { get; set; }
    }
}
