namespace KellyBlog.DAL.Entities
{
    public class Share : BaseEntity
    {
        public User User { get; set; }
        public string? UserId { get; set; }
        public string? Shares { get; set; }
    }
}
