using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Dtos.CommentDto
{
    public class UpdateCommentDto : IDto
    {
        public Guid Id { get; set; }
        public Guid VideoId { get; set; }
        public Guid UserId { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Content { get; set; }
    }
}