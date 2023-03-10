namespace KellyBlog.BLL.ViewModels
{
    public class UserVm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public IEnumerable<PostVm>? Posts { get; set; }
    }
}
