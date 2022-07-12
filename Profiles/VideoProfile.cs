using AutoMapper;
using YoutCubeEntitiesMicroservice.Dtos;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            // Source -> Target
            CreateMap<Video, VideoDto>();
        }
    }
}