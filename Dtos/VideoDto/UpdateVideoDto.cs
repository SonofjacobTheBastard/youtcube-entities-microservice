
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Dtos.VideoDto
{
    public class UpdateVideoDto : IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
    }
}