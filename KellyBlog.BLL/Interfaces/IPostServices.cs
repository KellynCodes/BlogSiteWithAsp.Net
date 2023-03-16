using KellyBlog.BLL.ViewModels;
using KellyBlog.DAL.Entities;

namespace KellyBlog.BLL.Interfaces
{
    public interface IPostServices
    {
        Task<(bool isSuccessful, string msg)> CreatePostAsync(PostVm post);
        Task<(bool isSuccessful, string msg)> DeletePostAsync(string userId);
        Task<(bool isSuccessful, string msg)> UpdatePostAsync(string userId, PostVm post);
        Task<(Post post, bool isSuccessful, string msg)> GetPostAsync(string userId, string post);
        Task<(bool isSuccessful, string msg, PostVm postVm)> GetAllPostAsync();
    }
}
