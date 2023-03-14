using AutoMapper;
using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using KellyBlog.DAL.Entities;
using KellyBlog.DAL.Repository;

namespace KellyBlog.BLL.Implementations
{
    public class CommentServices : ICommentServices
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<Comment> _commentRepo;


        public CommentServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _commentRepo = _unitOfWork.GetRepository<Comment>();
        }
        public async Task<(bool IsSuccessful, string msg)> CommentOnPostAsync(CommentsVm commentsVm)
        {
            // var newTask = _mapper.Map<PostVm, Post>(model);
            Console.WriteLine(commentsVm.PostId);
            var newComment = _mapper.Map<Comment>(commentsVm);
            await _commentRepo.AddAsync(newComment);
            var rowChanges = await _unitOfWork.SaveChangesAsync();
            return rowChanges > 0 ? (true, $"Task: {commentsVm.UserName} you comment was successfully created!") : (false, "Failed To save changes!");
        }

        public Task<(bool IsSuccessful, string msg)> DeleteCommentAsync(Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<(bool IsSuccessful, string msg)> EditCommentAsync(Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
