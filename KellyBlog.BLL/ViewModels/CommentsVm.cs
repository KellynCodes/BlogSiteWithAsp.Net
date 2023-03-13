using System.ComponentModel.DataAnnotations;

namespace KellyBlog.BLL.ViewModels
{
    public class CommentsVm
    {
        public Guid PostId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        [Required, StringLength(5000, ErrorMessage ="Input length cannot be greater than 5000")]
        public string Message { get; set; }
    }
}
