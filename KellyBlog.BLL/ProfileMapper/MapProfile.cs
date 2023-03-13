using AutoMapper;
using KellyBlog.BLL.ViewModels;
using KellyBlog.DAL.Entities;

namespace KellyBlog.BLL.ProfileMapper
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<CommentsVm, CommentsVm>();
            //.ForMember(dest => dest., opt => opt.MapFrom(src => src.Title));
        }
    }
}
