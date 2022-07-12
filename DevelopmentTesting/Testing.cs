using YoutCubeEntitiesMicroservice.Models;
using YoutCubeEntitiesMicroservice.Repositories;
using YoutCubeRelationalDatabaseConnection.Context;

namespace YoutCubeEntitiesMicroservice.DevelopmentTesting
{
    public class Testing
    {
        private VideoRepository videoRepository;
        public Testing(CommonContext context, VideoRepository repo)
        {
            videoRepository = repo;
            videoRepository.AddAsync(new Video()
            {
                Title = "Demo",
                Url = "https://www.youtube.com/watch?v=CwpSu6ELa2c&ab_channel=bearmanlee",
                Description = "DEMOMMOO"
            });
        }
    }
}