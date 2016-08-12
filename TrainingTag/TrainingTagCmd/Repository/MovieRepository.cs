using System.Collections.Generic;
using TrainingTagCmd.Models;

namespace TrainingTagCmd.Repository
{
    public class MovieRepository
    {
        public Movie Get()
        {
            return new Movie();
        }

        public List<Movie> GetAll()
        {
            return new List<Movie>();
        }
    }
}