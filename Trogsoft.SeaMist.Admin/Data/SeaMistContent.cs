namespace Trogsoft.SeaMist.Core.Data
{
    public class SeaMistContent<TUser, TKey> : SeaMistTitledEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public TKey OwnerId { get; set; } = default!;
        public TUser Owner { get; set; } = default!;
        public DateTime LastUpdated { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsDraft { get; set; }
        public ICollection<SeaMistContentVersion<TUser, TKey>> ContentVersions { get; set; } = new HashSet<SeaMistContentVersion<TUser, TKey>>();
        public ICollection<SeaMistCollectionContent<TUser, TKey>> Collections { get; set; } = new HashSet<SeaMistCollectionContent<TUser, TKey>>(); 
    }
}