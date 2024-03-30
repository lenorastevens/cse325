using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MasteryProteinVendors.Models
{
    public class Vendor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int ZipCode { get; set; }
        public List<string> Notes { get; set; } = [];
    }
}
