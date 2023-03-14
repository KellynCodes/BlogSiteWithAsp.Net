namespace KellyBlog.DAL.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public IEnumerable<Post>? Posts { get; set; }
        public string? PostId { get; set; }
    }
}
