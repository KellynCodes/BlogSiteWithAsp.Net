using KellyBlog.BLL.ViewModels;

namespace KellyBlog.BLL.Interfaces
{
    public interface ICommentServices
    {
        Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(int postId, CommentsVm commentsVm);
        Task<(bool IsSuccessful, string msg)> EditCommentAsync(int postId, Guid userId);
        Task<(bool IsSuccessful, string msg)> DeleteCommentAsync(int postId, Guid userId);
    }
}
