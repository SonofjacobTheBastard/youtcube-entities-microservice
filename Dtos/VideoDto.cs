
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Dtos
{
    public class VideoDto : IDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public List<CommentDto>? Comments { get; set; }

        public VideoDto(string title, string url, string description)
        {
            Id = new Guid();
            Title = title;
            Url = url;
            Description = description;
            Views = 0;
            Comments = new List<CommentDto>();
        }

    }
}