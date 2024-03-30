namespace MasteryProteinVendors.Models
{
    public class MasteryProteinDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string VendorsCollectionName { get; set; } = null!;
    }
}
