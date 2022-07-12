using YoutCubeRelationalDatabaseConnection.Interfaces;

namespace YoutCubeEntitiesMicroservice.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}