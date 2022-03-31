using _06_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository
{
    public class ContentRepository : StreamingContentRepository
    {
        //creat
        //read
        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show) // similar to GetType == TypeOf
                {
                    allShows.Add(content as Show); //similar to casting
                }
            }
            return allShows;
        }
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie) // similar to GetType == TypeOf
                {
                    allMovies.Add(content as Movie); //similar to casting
                }
            }
            return allMovies;
        }

        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
                
            }
            return null;
        }
        public Movie GetShowByMovie(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        //update
        //delete
    }
}
