using KellyBlog.BLL.ViewModels;

namespace KellyBlog.BLL.Interfaces
{
    public interface IPostServices
    {
        Task<(bool isSuccessful, string msg)> CreatePostAsync(PostVm post);
        Task<(bool isSuccessful, string msg)> DeletePostAsync(PostVm post);
        Task<(bool isSuccessful, string msg)> UpdatePostAsync(Guid userId, PostVm post);
        Task<(bool isSuccessful, string msg)> GetPostAsync(Guid userId, Guid post);
        Task<(bool isSuccessful, string msg)> GetAllPostAsync();
    }
}
