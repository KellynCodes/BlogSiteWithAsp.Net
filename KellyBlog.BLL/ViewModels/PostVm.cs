namespace KellyBlog.BLL.ViewModels
{
    public class PostVm
    {
        public Guid PostId { get; set; } = Guid.NewGuid();
            public Guid UserId { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public string Image { get; set; } 
            public long Likes { get; set; }
            public long Shares { get; set; }
            public IEnumerable<CommentsVm>? Comments { get; set; }
    }
}
