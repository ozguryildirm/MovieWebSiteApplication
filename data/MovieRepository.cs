using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="Shazam", 
                    Description = "<p>We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam.</p>",
                    ShortDescription="Shazam", 
                    ImageUrl="1.jpeg",
                    CategoryId = 1
                },
                new Movie()
                {
                    Id=2, 
                    Name="Amazing Grace", 
                    Description = "<p>We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam.</p>",
                    ShortDescription="Amazing Grace", 
                    ImageUrl="2.jpeg",
                    CategoryId = 2
                },
                new Movie() 
                {
                    Id=3, 
                    Name="High Life", 
                    Description = "<p>We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam.</p>",
                    ShortDescription="High Life", 
                    ImageUrl="3.jpeg",
                    CategoryId = 2
                },
                new Movie() 
                {
                    Id=4,
                    Name="Billboard",
                    Description = "<p>We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam.</p>", 
                    ShortDescription="Billboard", 
                    ImageUrl="4.jpeg",
                    CategoryId = 3
                },
                new Movie()
                {
                    Id=5, 
                    Name="Storm Boy", 
                    Description = "<p>We all have a superhero inside us, it just takes a bit of magic to bring it out. In Billy Batson's case, by shouting out one word - SHAZAM - this streetwise fourteen-year-old foster kid can turn into the grown-up superhero Shazam.</p>",
                    ShortDescription="Storm Boy", 
                    ImageUrl="5.jpeg",
                    CategoryId = 3
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i=>i.Id ==id);
        }
    }
}