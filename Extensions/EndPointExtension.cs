
using AutoMapper;
using YoutCubeEntitiesMicroservice.Interfaces;
using YoutCubeEntitiesMicroservice.Dtos.VideoDto;
using YoutCubeEntitiesMicroservice.Models;
using YoutCubeEntitiesMicroservice.Dtos.CommentDto;

namespace YoutCubeEntitiesMicroservice.Extensions
{
    public static class EndPointExtension
    {
        public static void MapCommentsEndPoint(this WebApplication app)
        {


            // app.MapGet("api/v1/comments", async (IRepository<Comment> repo, IMapper mapper, Video videoDto) =>
            // {
            //     var comments = await repo.GetAllAsync(c => c.VideoId == videoDto.Id);
            //     return Results.Ok(mapper.Map<IEnumerable<CommentDto>>(comments));
            // });

            app.MapGet("api/v1/comments/{id}", async (IRepository<Comment> repo, IMapper mapper, Guid id) =>
            {
                var comment = await repo.GetByIdAsync(id);
                if (comment != null)
                {
                    return Results.Ok(mapper.Map<ReadCommentDto>(comment));
                }
                return Results.NotFound();
            });

            app.MapPost("api/v1/comments", async (IRepository<Comment> repo, IMapper mapper, CreateCommentDto CommentDto) =>
            {
                var comment = mapper.Map<Comment>(CommentDto);

                await repo.AddAsync(comment);

                var CommentReadDto = mapper.Map<ReadCommentDto>(comment);

                return Results.Created($"api/v1/comments/{CommentReadDto.Id}", CommentReadDto);

            });

            app.MapPut("api/v1/comments/{id}", async (IRepository<Comment> repo, IMapper mapper, Guid id, UpdateCommentDto CommentDto) =>
            {
                var comment = repo.GetByIdAsync(CommentDto.Id).Result;
                if (comment == null)
                {
                    return Results.NotFound();
                }
                comment = mapper.Map<Comment>(CommentDto);
                await repo.UpdateAsync(comment);
                return Results.NoContent();
            });

            app.MapDelete("api/v1/comments/{id}", async (IRepository<Comment> repo, IMapper mapper, Guid id) =>
            {
                await repo.DeleteAsync(id);
                return Results.NoContent();
            });


        }
        public static void MapVideosEndpoints(this WebApplication app)
        {

            app.MapGet("api/v1/videos", async (IRepository<Video> repo, IMapper mapper) =>
            {
                var videos = await repo.GetAllAsync();
                return Results.Ok(mapper.Map<IEnumerable<ReadVideoDto>>(videos));
            });

            app.MapGet("api/v1/videos/{id}", async (IRepository<Video> repo, IMapper mapper, Guid id) =>
            {
                var video = await repo.GetByIdAsync(id);
                if (video != null)
                {
                    return Results.Ok(mapper.Map<ReadVideoDto>(video));
                }
                return Results.NotFound();
            });

            app.MapPost("api/v1/videos", async (IRepository<Video> repo, IMapper mapper, CreateVideoDto videoDto) =>
            {
                var video = mapper.Map<Video>(videoDto);

                await repo.AddAsync(video);

                var videoReadDto = mapper.Map<ReadVideoDto>(video);

                return Results.Created($"api/v1/videos/{videoReadDto.Id}", videoReadDto);

            });

            app.MapPut("api/v1/videos/{id}", async (IRepository<Video> repo, IMapper mapper, Guid id, ReadVideoDto videoDto) =>
            {
                var video = repo.GetByIdAsync(videoDto.Id).Result;
                if (video == null)
                {
                    return Results.NotFound();
                }
                video = mapper.Map<Video>(videoDto);
                await repo.UpdateAsync(video);
                return Results.NoContent();
            });

            app.MapDelete("api/v1/videos/{id}", async (IRepository<Video> repo, IMapper mapper, Guid id) =>
            {
                await repo.DeleteAsync(id);
                return Results.NoContent();
            });


        }
    }
}