namespace KellyBlog.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public long? Likes { get; set; }
        public long? Replies { get; set; }
    }
}
