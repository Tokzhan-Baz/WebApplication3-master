using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.Movies;

namespace WebApplication3.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = -1,
                Author = "Todd Phillips",
                Genre = "Crime , Drama , Thriller",
                Name = "Joker",
                Poster = "http://image.tmdb.org/t/p/w185//nBNZadXqJSdt05SHLqgT0HuC5Gm.jpg",
                CreatedAt = new DateTime(2019, 10, 3)
            },
            new Movie
            {
                Id = -2,
                Author = "David Leitch",
                Genre = "Action , Adventure",
                Name = "Fast & Furious Presents: Hobbs &",
                Poster = "https://camo.githubusercontent.com/2921202280866f3d1d35e68968b10ca1423d2254/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424e6a6b324f44517a4e4459784e5635424d6c3542616e426e586b46745a5467774d5463794e4467344e6a45402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067",
                CreatedAt = new DateTime(2019, 8, 2)
            },
            new Movie
            {
                Id = -3,
                Author = "Jon Favreau",
                Genre = "Adventure , Animation , Drama , Family , Musical",
                Name = "The Lion King",
                Poster = "https://camo.githubusercontent.com/03a3a78891c3d594d29f8d008d9bbf589b35c198/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424d5463324d5451334d4441314e6c35424d6c3542616e426e586b46745a5467774f4441334f5449344e6a45402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067",
                CreatedAt = new DateTime(2019, 7, 19)
            },
            new Movie
            {
                Id = -4,
                Author = "Joachim Rønning",
                Genre = "Adventure , Family , Fanta sy",
                Name = "Maleficent: Mistress of Evil",
                Poster = "https://camo.githubusercontent.com/21ed484b2dc8b4c1156069f29143d01f4bbb72c4/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424e7a517a4f546b334f5441744e4451305a6930305a54566b4c5749304d5445744d446c6c5a6a4e6b597a4e6a4e5463344c326c745957646c586b4579586b467163476465515856794e6a55304f5451304f5459402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067",
                CreatedAt = new DateTime(2019, 10, 18)
            });
        }
    }
}
