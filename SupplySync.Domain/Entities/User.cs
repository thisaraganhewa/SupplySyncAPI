using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SupplySync.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplySync.Domain.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; } = null!;

        public string EmployeeId { get; private set; } = null!;

        public string FirstName { get; private set; } = null!;

        public string LastName { get; private set; } = null!;

        public string Email { get; private set; } = null!;

        public string PasswordHash { get; private set; } = null!;

        public UserStatus Status { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime? UpdatedAt { get; private set; }

        public DateTime? LastLoginAt { get; private set; }
    }
}
