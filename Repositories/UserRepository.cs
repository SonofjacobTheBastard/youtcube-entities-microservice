using YoutCubeRelationalDatabaseConnection.Context;
using YoutCubeRelationalDatabaseConnection.Repositories;
using YoutCubeEntitiesMicroservice.Models;

namespace YoutCubeEntitiesMicroservice.Repositories
{
    public class UserRepository : CommonRepository<User>
    {
        public UserRepository(CommonContext context) : base(context)
        {
        }
    }
}