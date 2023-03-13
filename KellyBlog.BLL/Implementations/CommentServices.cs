using AutoMapper;
using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using TodoList.DAL.Repository;

namespace KellyBlog.BLL.Implementations
{
    public class CommentServices : ICommentServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<CommentsVm> _commentVmRepo;


        public CommentServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _commentVmRepo = _unitOfWork.GetRepository<CommentsVm>();
        }
        public async Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(int postId, CommentsVm commentsVm)
        {
            // var newTask = _mapper.Map<PostVm, Post>(model);
            Console.WriteLine(commentsVm.PostId);
            var newComment = _mapper.Map<CommentsVm>(commentsVm);
            await _commentVmRepo.AddAsync(newComment);
            var rowChanges = await _unitOfWork.SaveChangesAsync();
            return rowChanges > 0 ? (true, $"Task: {commentsVm.Name} you comment was successfully created!") : (false, "Failed To save changes!");
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
