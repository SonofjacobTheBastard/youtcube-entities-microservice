
using YoutCubeRelationalDatabaseConnection.Interfaces;
using YoutCubeEntitiesMicroservice.Dtos;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Extensions
{
    public static class DtoExtensions
    {
        public static IEnumerable<IDto> AsDto(this IEnumerable<IEntity> list)
        {
            IEnumerable<IDto> result = new List<IDto>();
            foreach (IEntity entity in list)
                result.Append(entity.AsDto());
            return result;
        }
        public static IDto AsDto(this IEntity entity) // Just In Case, Maybe Remove Method? 
        {
            if (entity.GetType() == typeof(Comment))
                return entity.AsDto();
            return entity.AsDto();
        }

        public static CommentDto AsDto(this Comment comment)
        {
            return new CommentDto
            (
                comment.Id,
                comment.VideoId,
                comment.UserId,
                comment.Likes,
                comment.CreatedAt,
                comment.Content
            );
        }

        public static VideoDto AsDto(this Video video)
        {
            List<CommentDto> commentDtos = new List<CommentDto>();

            foreach (Comment comment in video.Comments!)
                commentDtos.Add(comment.AsDto());

            return new VideoDto
            (
                video.Id,
                video.Title,
                video.Url,
                video.Description,
                video.Views,
                commentDtos
            );
        }
    }
}