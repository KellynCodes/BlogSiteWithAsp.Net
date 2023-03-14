namespace KellyBlog.BLL.ViewModels
{
    public class PostVm
    {
        public string PostId { get; set; } = Guid.NewGuid().ToString();
            public string UserId { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public string Image { get; set; } 
            public string Likes { get; set; }
            public string SharesId { get; set; }
            public string Shares { get; set; }
            public IEnumerable<CommentsVm>? Comments { get; set; }
            public string? CommentId {get; set;}
    }
}
