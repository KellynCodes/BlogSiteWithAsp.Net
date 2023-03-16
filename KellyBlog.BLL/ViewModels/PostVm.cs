using System.ComponentModel.DataAnnotations;

namespace KellyBlog.BLL.ViewModels
{
    public class PostVm
    {

            public string PostId { get; set; } 
            public string UserId { get; set; }
            [Required(ErrorMessage = "This field is required")] 
            [StringLength(100, ErrorMessage = "Input can not be less than or more than 100 characters.",  MinimumLength = 10)]
            public string Title { get; set; }
            [Required]
            [StringLength(2000, ErrorMessage = "Input can not be less than 10 or more than 2000 characters.", MinimumLength = 10)]
            public string Body { get; set; }
            public string? Image { get; set; } 
            public string? Likes { get; set; }
            public string? SharesId { get; set; }
            public string? CommentId {get; set;}
            public DateTime CreatedDated { get; set; } = DateTime.UtcNow;
            public DateTime? UpdatedDated { get; set; }
            public byte[]? Concurrency { get; set; }
    }
}