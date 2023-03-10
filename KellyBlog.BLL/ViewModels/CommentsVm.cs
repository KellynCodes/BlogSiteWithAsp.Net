using System.ComponentModel.DataAnnotations;

namespace KellyBlog.BLL.ViewModels
{
    public class CommentsVm
    {
        [Required, StringLength(5000, ErrorMessage ="Input lenght cannot be greater than 5000")]
        public string Message { get; set; }
        public UserVm User { get; set; }
        public long? Likes { get; set; }
        public long? Replies { get; set; }
    }
}
