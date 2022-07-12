

using YoutCubeRelationalDatabaseConnection.Interfaces;

namespace YoutCubeEntitiesMicroservice.Models
{


    public class Comment : IEntity
    {
        public Guid Id { get; set; }
        public Guid VideoId { get; set; }
        public Guid UserId { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }

        public Comment()
        {

        }
        public Comment(Guid videoId, Guid userId, string content)
        {
            Id = new Guid();
            VideoId = videoId;
            UserId = userId;
            Likes = 0;
            CreatedAt = DateTime.Now;
            Content = content;

        }
    }

}