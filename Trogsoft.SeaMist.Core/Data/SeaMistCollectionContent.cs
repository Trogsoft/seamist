namespace Trogsoft.SeaMist.Core.Data
{
    public class SeaMistCollectionContent<TUser, TKey> 
    {
        public long ContentId { get; set; }
        public SeaMistContent<TUser, TKey> Content { get; set; } = null!;
        public long CollectionId { get; set; }
        public SeaMistContentCollection<TUser, TKey> Collection { get; set; } = null!;
    }
}