using KellyBlog.BLL.Interfaces;

namespace KellyBlog.BLL.Implementations
{
    public class BlogAuth : IBlogAuth
    {
        public async Task<(bool isSuccessful, string msg)> CreateUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(bool isSuccessful, string msg)> DeleteUserAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(bool isSuccessful, string msg)> LoginAuthAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(bool isSuccessful, string msg)> UpdateUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
