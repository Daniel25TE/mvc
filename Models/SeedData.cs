using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Exorcista",
                    ReleaseDate = DateTime.Parse("1973-12-26"),
                    Genre = "Horror",
                    Price = 15.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Buscando a Nemo",
                    ReleaseDate = DateTime.Parse("2003-5-30"),
                    Genre = "Adventure",
                    Price = 10.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Avengers: Doomsday",
                    ReleaseDate = DateTime.Parse("2026-12-18"),
                    Genre = "Fiction",
                    Price = 20.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}