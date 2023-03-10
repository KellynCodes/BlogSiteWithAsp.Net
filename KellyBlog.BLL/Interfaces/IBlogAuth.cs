namespace KellyBlog.BLL.Interfaces
{
    public interface IBlogAuth
    {
        Task<(bool isSuccessful, string msg)> CreateUserAsync();
        Task<(bool isSuccessful, string msg)> UpdateUserAsync();
        Task<(bool isSuccessful, string msg)> LoginAuthAsync();
        Task<(bool isSuccessful, string msg)> DeleteUserAsync();
    }
}
