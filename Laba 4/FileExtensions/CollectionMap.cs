using CsvHelper.Configuration;

namespace Laba7
{
    internal class CollectionMap : ClassMap<Collection.AgronomistRecord>
    {
        public CollectionMap()
        {
            Map(m => m.CultureName).Name(nameof(Collection.AgronomistRecord.CultureName));
            Map(m => m.FertilizerName).Name(nameof(Collection.AgronomistRecord.FertilizerName));
            Map(m => m.ApplicationRate).Name(nameof(Collection.AgronomistRecord.ApplicationRate));
            Map(m => m.EntryDate).Name(nameof(Collection.AgronomistRecord.EntryDate));
            Map(m => m.ContentInVolume).Name(nameof(Collection.AgronomistRecord.ContentInVolume));
        }
    }
}
