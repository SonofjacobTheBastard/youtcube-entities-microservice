
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Models
{


    public class Video : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Url { get; set; } = "";
        public string Description { get; set; } = "";
        public int Views { get; set; }
        public List<Comment>? Comments { get; set; }
        public Video(string title, string url, string description)
        {
            Id = new Guid();
            Title = title;
            Url = url;
            Description = description;
            Views = 0;
            Comments = new List<Comment>();
        }
        public Video()
        {

        }
    }

}