namespace YoutCubeEntitiesMicroservice.Dtos
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public Guid VideoId { get; set; }
        public Guid UserId { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }

        public CommentDto(Guid id, Guid videoId, Guid userId, int likes, DateTime createdAt, string content)
        {
            Id = id;
            VideoId = videoId;
            UserId = userId;
            Likes = likes;
            CreatedAt = createdAt;
            Content = content;
        }
    }
}