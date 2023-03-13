namespace KellyBlog.DAL.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Guid CommentsId { get; set; } = Guid.NewGuid();
        public long Likes { get; set; }
        public Share Share { get; set; }
        public Guid ShareId { get; set; } = Guid.NewGuid();
    }
}
