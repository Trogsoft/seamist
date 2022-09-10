namespace Trogsoft.SeaMist.Core.Data
{
    public class SeaMistContentVersion<TUser, TKey>
    {
        public long Id { get; set; }
        public DateTime Time { get; set; }
        public TKey UserId { get; set; } = default!;
        public TUser User { get; set; } = default!;
        public string Content { get; set; } = null!;

    }
}