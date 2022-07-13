using AutoMapper;
using YoutCubeEntitiesMicroservice.Dtos.VideoDto;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            // Source -> Target


            CreateMap<Video, ReadVideoDto>();
            CreateMap<CreateVideoDto, Video>();
            CreateMap<UpdateVideoDto, Video>();
        }
    }
}