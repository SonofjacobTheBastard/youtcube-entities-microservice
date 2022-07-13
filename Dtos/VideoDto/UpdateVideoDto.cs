
using YoutCubeEntitiesMicroservice.Interfaces;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Dtos.VideoDto
{
    public class UpdateVideoDto : IDto
    {
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
    }
}