namespace YoutCubeEntitiesMicroservice.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}