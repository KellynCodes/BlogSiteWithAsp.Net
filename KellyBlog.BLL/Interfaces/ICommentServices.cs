using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellyBlog.BLL.Interfaces
{
    public interface ICommentServices
    {
        Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(int postId, Guid userId);
        Task<(bool IsSuccessful, string msg)> EditCommentAsync(int postId, Guid userId);
        Task<(bool IsSuccessful, string msg)> DeleteCommentAsync(int postId, Guid userId);
    }
}
