namespace KellyBlog.DAL.Entities
{
    public class Share : BaseEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; } = new Guid();
        public long Shares { get; set; }
    }
}
