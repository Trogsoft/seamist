namespace Trogsoft.SeaMist.Core.Data
{
    public class SeaMistContentCollection<TUser, TKey> : SeaMistTitledEntity
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public TKey OwnerId { get; set; } = default!;
        public TUser Owner { get; set; } = default!;
        public ICollection<SeaMistCollectionContent<TUser, TKey>> Content { get; set; } = new HashSet<SeaMistCollectionContent<TUser, TKey>>();
    }
}