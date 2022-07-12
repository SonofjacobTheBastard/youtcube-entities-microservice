
using AutoMapper;
using YoutCubeEntitiesMicroservice.Dtos;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            // Source -> Target
            CreateMap<Comment, CommentDto>();
        }
    }
}