using MongoDB.Bson.Serialization.Attributes;

namespace TrainingTagCmd.Models
{
    [BsonIgnoreExtraElements]
    public class Movie
    {
        [BsonId]
        [BsonElement("_id")]
        public int Id { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("key")]
        public string Key { get; set; }
        [BsonElement("poster")]
        public string Poster { get; set; }
    }
}