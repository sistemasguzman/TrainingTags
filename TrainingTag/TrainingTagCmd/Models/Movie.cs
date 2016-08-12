using MongoDB.Bson.Serialization.Attributes;

namespace TrainingTagCmd.Models
{
    [BsonIgnoreExtraElements]
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Key { get; set; }
        public string Poster { get; set; }
    }
}