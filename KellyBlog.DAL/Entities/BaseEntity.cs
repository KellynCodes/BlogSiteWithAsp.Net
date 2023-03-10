namespace KellyBlog.DAL.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = new Guid();
        public DateTime CreatedDated { get; set; }
        public DateTime? UpdatedDated { get; set; }
        public byte[]? Concurrency { get; set; }
    }
}
