using MasteryProteinVendors.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MasteryProteinVendors.Services
{
    public class VendorsService
    {
        private readonly IMongoCollection<Vendor> _vendorsCollection;

        public VendorsService(IOptions<MasteryProteinDatabaseSettings> masteryProteinDatabaseSettings)
        {
            var mongoClient = new MongoClient(masteryProteinDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(masteryProteinDatabaseSettings.Value.DatabaseName);

            _vendorsCollection = mongoDatabase.GetCollection<Vendor>(masteryProteinDatabaseSettings.Value.VendorsCollectionName);
        }

        public async Task<List<Vendor>> GetAsync() =>
            await _vendorsCollection.Find(_ => true).ToListAsync();

        public async Task<Vendor?> GetAsync(string id) =>
            await _vendorsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Vendor newVendor) =>
            await _vendorsCollection.InsertOneAsync(newVendor);

        public async Task UpdateAsync(string id, Vendor updatedVendor) =>
            await _vendorsCollection.ReplaceOneAsync(x => x.Id == id, updatedVendor);

        public async Task RemoveAsync(string id) =>
            await _vendorsCollection.DeleteOneAsync(x => x.Id == id);
    }
}
