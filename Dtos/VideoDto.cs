
using YoutCubeRelationalDatabaseConnection.Interfaces;

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

        public VideoDto(Guid id, string title, string url, string description, int views, List<CommentDto> comments)
        {
            Id = id;
            Title = title;
            Url = url;
            Description = description;
            Views = views;
            Comments = comments;
        }

    }
}