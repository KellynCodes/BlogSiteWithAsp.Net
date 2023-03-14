namespace KellyBlog.DAL.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDated { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDated { get; set; }
        public byte[]? Concurrency { get; set; }
    }
}
