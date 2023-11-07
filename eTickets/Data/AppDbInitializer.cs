using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if(!context.Cinemas.Any() )
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo ="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo ="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo ="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"

                        },
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo ="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"

                        },
                    });
                    context.SaveChanges();

                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() {
                        FullName = "Actor 1",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                         new Actor() {
                        FullName = "Actor 2",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                          new Actor() {
                        FullName = "Actor 3",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                           new Actor() {
                        FullName = "Actor 4",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                         new Actor() {
                        FullName = "Actor 5",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer() {
                        FullName = "Actor 1",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                         new Producer() {
                        FullName = "Actor 2",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                          new Producer() {
                        FullName = "Actor 3",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                           new Producer() {
                        FullName = "Actor 4",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                         new Producer() {
                        FullName = "Actor 5",
                        Bio="This is the Bio of the second actor",
                        ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie() {
                       Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-1.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                         new Movie() {
                        Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-2.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                          new Movie() {
                       Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-3.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                           new Movie() {
                       Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-4.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                         new Movie() {
                       Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-5.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                          new Movie() {
                       Name = "Race",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-6.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Horrer
                        },
                           new Movie() {
                       Name = "Scoob",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-7.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        },
                            new Movie() {
                       Name = "Cold Soles",
                       Description = "This is Scoob movie description",
                       Price=39.50,
                       ImageURL ="http://dotnethow.net/images/movies/movie-8.jpeg",
                       Startdate = DateTime.Now.AddDays(-10),
                       Enddate = DateTime.Now.AddDays(-2),
                       CinemaId = 1,
                       ProducerId = 3,
                       MovieCategory=MovieCategory.Cartoon
                        }
                    });
                    context.SaveChanges();

                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {

                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() {
                            ActorId = 1,
                            MovieId=5

                        },
                         new Actor_Movie() {
                            ActorId = 3,
                            MovieId=4

                        },
                          new Actor_Movie() {
                            ActorId = 5,
                            MovieId=3

                        },
                           new Actor_Movie() {
                            ActorId = 2,
                            MovieId=3

                        },
                            new Actor_Movie() {
                            ActorId = 4,
                            MovieId=1

                        },
                    });
                    context.SaveChanges();
                

                }


       }     }
            
    }
}
