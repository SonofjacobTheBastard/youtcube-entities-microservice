
using YoutCubeEntitiesMicroservice.Interfaces;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Dtos.VideoDto
{
    public class ReadVideoDto : IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }

    }
}