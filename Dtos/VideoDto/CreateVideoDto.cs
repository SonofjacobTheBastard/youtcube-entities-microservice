
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Dtos.VideoDto
{
    public class CreateVideoDto : IDto
    {
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
    }
}