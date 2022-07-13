using YoutCubeEntitiesMicroservice.Context;
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