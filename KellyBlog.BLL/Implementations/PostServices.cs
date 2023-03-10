using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using KellyBlog.DAL.Entities;
using TodoList.DAL.Repository;
using AutoMapper;

namespace KellyBlog.BLL.Implementations
{
    public class PostServices : IPostServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<User> _userRepo;
        private readonly IRepository<Post> _postRepo;


        public PostServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userRepo = _unitOfWork.GetRepository<User>();
            _postRepo = _unitOfWork.GetRepository<Post>();
        }



        public async Task<(bool isSuccessful, string msg)> CreatePostAsync(PostVm postVm)
        {
            // var newTask = _mapper.Map<PostVm, Post>(model);
            var newTask = _mapper.Map<Post>(postVm);
              await _postRepo.AddAsync(newTask);
                var rowChanges = await _unitOfWork.SaveChangesAsync();
                return rowChanges > 0 ? (true, $"Task: {postVm.Title} was successfully created!") : (false, "Failed To save changes!");
        }

        public Task<(bool isSuccessful, string msg)> DeletePostAsync(PostVm post)
        {
            throw new NotImplementedException();
        }

        public Task<(bool isSuccessful, string msg)> GetAllPostAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(bool isSuccessful, string msg)> GetPostAsync(Guid userId, Guid post)
        {
            //_userRepo.GetBySingIdAsync();

            return (true, "Users fetched successfully.");
        }

        public Task<(bool isSuccessful, string msg)> UpdatePostAsync(Guid userId, PostVm post)
        {

            throw new NotImplementedException();
        }
    }
}
