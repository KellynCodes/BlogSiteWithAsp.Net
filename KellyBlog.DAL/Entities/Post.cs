namespace KellyBlog.DAL.Entities
{
    public class Post : BaseEntity
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string? Image { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public string? CommentsId { get; set; }
        public string? Likes { get; set; }
        public Share? Share { get; set; }
        public string? ShareId { get; set; }
    }
}