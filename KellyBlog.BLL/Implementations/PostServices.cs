﻿using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using KellyBlog.DAL.Entities;
using KellyBlog.DAL.Repository;
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

        public async Task<(bool isSuccessful, string msg)> DeletePostAsync(string userId)
        {
            var PostToDel = await _postRepo.GetByIdAsync(userId);
            await _postRepo.DeleteAsync(PostToDel);
            await _unitOfWork.SaveChangesAsync();
            var rowChanges = await _unitOfWork.SaveChangesAsync();
            return rowChanges > 0 ? (true, $"Task: {PostToDel.Title} was successfully deleted!") : (false, "Failed To save changes!");
        }

        public Task<(bool isSuccessful, string msg, PostVm postVm)> GetAllPostAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(Post post, bool isSuccessful, string msg)> GetPostAsync(string userId, string postId)
        {
           Post fetchedPost = await _postRepo.GetSingleByAsync(post => post.Id == postId && post.UserId == userId, tracking: true);
           if(fetchedPost != null) return (fetchedPost, true, "Post fetched successfully.");
           return (fetchedPost, false, "Error occurred please try again.");
        }

        public Task<(bool isSuccessful, string msg)> UpdatePostAsync(string userId, PostVm post)
        {

            throw new NotImplementedException();
        }
    }
}
