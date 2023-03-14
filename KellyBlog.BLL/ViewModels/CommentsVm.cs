using System.ComponentModel.DataAnnotations;

namespace KellyBlog.BLL.ViewModels
{
    public class CommentsVm
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? PostId { get; set; }
        [Required, StringLength(5000, ErrorMessage = "Input length cannot be greater than 5000")]
        public string Content { get; set; }
        public string? UserId { get; set; }
        public long? Likes { get; set; }
        public long? Replies { get; set; }
    }
}
