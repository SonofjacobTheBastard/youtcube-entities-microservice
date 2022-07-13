using YoutCubeEntitiesMicroservice.Context;
using YoutCubeEntitiesMicroservice.Repositories;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Repositories
{
    public class CommentRepository : CommonRepository<Comment>
    {
        public CommentRepository(CommonContext context) : base(context)
        {
        }
    }
}