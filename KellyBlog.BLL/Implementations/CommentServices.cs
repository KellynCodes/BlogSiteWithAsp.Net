using KellyBlog.BLL.Interfaces;

namespace KellyBlog.BLL.Implementations
{
    public class Comment : ICommentServices
    {
        public Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(int postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSuccessful, string msg)> DeleteCommentAsync(int postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSuccessful, string msg)> EditCommentAsync(int postId, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
