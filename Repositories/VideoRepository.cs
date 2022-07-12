using YoutCubeRelationalDatabaseConnection.Context;
using YoutCubeRelationalDatabaseConnection.Repositories;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Repositories
{
    public class VideoRepository : CommonRepository<Video>
    {
        public VideoRepository(CommonContext context) : base(context)
        {
          
        }
    }
}