using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageName = "best-two-years.webp"
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Adventure",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageName = "other-side-of-heaven.jpg"
                    },
                    new Movie
                    {
                        Title = "Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-01-30"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "PG",
                        ImageName = "singles-ward.webp"
                    },
                    new Movie
                    {
                        Title = "Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-12-11"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG",
                        ImageName = "singles-second-ward.jpg"
                    },
                    new Movie
                    {
                        Title = "The Mountain of the Lord",
                        ReleaseDate = DateTime.Parse("1993-3-1"),
                        Genre = "Documentary",
                        Price = 4.99M,
                        Rating = "E",
                        ImageName = "mountain-of-the-lord.webp"
                    },
                    new Movie
                    {
                        Title = "Saturday's Warrior",
                        ReleaseDate = DateTime.Parse("1989-1-1"),
                        Genre = "Family",
                        Price = 2.99M,
                        Rating = "E",
                        ImageName = "saturdays-warrior.jpg"
                    },
                    new Movie
                    {
                        Title = "Legacy: A Mormon Journey",
                        ReleaseDate = DateTime.Parse("1993-7-3"),
                        Genre = "Historical",
                        Price = 5.99M,
                        Rating = "E",
                        ImageName = "legacy.jpg"
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Drama",
                        Price = 3.99M,
                        Rating = "PG",
                        ImageName = "17-miracles.webp"
                    },
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-01-24"),
                        Genre = "Drama",
                        Price = 4.99M,
                        Rating = "PG",
                        ImageName = "the-rm.webp"
                    },
                    new Movie
                    {
                        Title = "Meet The Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 6.99M,
                        Rating = "PG",
                        ImageName = "meet-the-mormons.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
