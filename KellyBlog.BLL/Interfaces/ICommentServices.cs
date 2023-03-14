using KellyBlog.BLL.ViewModels;

namespace KellyBlog.BLL.Interfaces
{
    public interface ICommentServices
    {
        Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(CommentsVm commentsVm);
        Task<(bool IsSuccessful, string msg)> EditCommentAsync(Guid postId, Guid userId);
        Task<(bool IsSuccessful, string msg)> DeleteCommentAsync(Guid postId, Guid userId);
    }
}
