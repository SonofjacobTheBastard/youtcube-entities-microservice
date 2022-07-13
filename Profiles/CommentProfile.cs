
using AutoMapper;
using YoutCubeEntitiesMicroservice.Dtos.CommentDto;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            // Source -> Target            
            CreateMap<Comment, ReadCommentDto>();
            CreateMap<CreateCommentDto, Comment>();
            CreateMap<UpdateCommentDto, Comment>();
        }
    }
}