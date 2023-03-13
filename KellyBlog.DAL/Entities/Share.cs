namespace KellyBlog.DAL.Entities
{
    public class Share : BaseEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; } = Guid.NewGuid();
        public long Shares { get; set; }
    }
}
