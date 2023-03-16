namespace KellyBlog.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string Content { get; set; }
        public User? User { get; set; }
        public string? UserId { get; set; }
        public Post? Post { get; set; }
        public string? PostId { get; set; }
        public string? Likes { get; set; }
        public string? Replies { get; set; }
    }
}
