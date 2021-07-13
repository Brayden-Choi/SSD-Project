using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MIST.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MIST.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MISTDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MISTDbContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Name = "Kingdom Spade III",
                        ReleaseDate = DateTime.Parse("2021-3-30"),
                        CoverImageName = "",
                        MediaName = "",
                        Genre = "Fantasy",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description = "Kingdom Spade III shares the power of friendship as Dora and his friends embark on an adventure. Travelling around the world, Kingdom Spades III follows the journey of Dora, a monkey and a map to a spectecular power.",
                        Developer = "Rectangle Phoenix",
                        Publisher = "Rectangle Phoneix",
                        Price = 80.10M
                    },

                   new Game
                   {
                       Name = "Undercooked!",
                       CoverImageName = "",
                       MediaName = "",
                       ReleaseDate = DateTime.Parse("2018-8-7"),
                       Genre = "Simulation",
                       FileType = "Soft Copy",
                       Device = "PC",
                       Description = "Undercooked is a calm cooking game for 1 to 4 players. Working individually, you must sabotage your fellow chefs. Sharpen your knives and dust off your chef’s whites, there is mushroom for error and the steaks are high in these crazy kitchens!",
                       Developer = "Human City Games and Team10 Digital Ltd",
                       Publisher = "Teal10 Digital Ltd",
                       Price = 18.99M
                   },

                    new Game
                    {
                        Name = "Imshin Genpact",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2020-9-28"),
                        Genre = "RPG",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description = "Embark on a journey across Tavyet to find your lost sibling and seek answers from The Seven — the 7-11 managers. Explore this wondrous world, join forces with a diverse range of characters, and unravel the countless mysteries that Tavyet holds...",
                        Developer = "YoHomi Unlimited",
                        Publisher = "YOHomi Unlimited",
                        Price = 0M
                    },


                    new Game
                    {
                        Name = "Socket League",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2020-9-24"),
                        Genre = "Football",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description = "Socket League is a high-powered hybrid of arcade-style soccer and technological mayhem with easy-to-understand controls and fluid, electrical-driven competition.",
                        Developer = "PSY",
                        Publisher = "PSY",
                        Price = 0M
                    },

                    new Game
                    {
                        Name = "The Manley Parable",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2013-10-17"),
                        Genre = "Indie",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description = "The Manley Parable is a first person exploration game. You will play as Stanley, and you will not play as Manley. You will follow a story, you will not follow a story. You will have a choice, you will have no choice. The game will end, the game will never end.",
                        Developer = "Galaxy Eatery",
                        Publisher = "Galaxy Eatery",
                        Price = 0M
                    },

                     new Game
                     {
                         Name = "=Claus=",
                         CoverImageName = "",
                         MediaName = "",
                         ReleaseDate = DateTime.Parse("2016-1-19"),
                         Genre = "Indie",
                         FileType = "Hard Copy",
                         Device = "PS4",
                         Description = "Claus is lost and alone. Who? Where? Why? He doesn't know anything. Only you can help him find the truth. Join Claus and K1 - a friendly brute - as you explore this puzzle platform game based on precision, through a geometric kaleidoscope world with high contrast and pop art.  ",
                         Developer = "Cosa La Entertainment",
                         Publisher = "Cosa La Entertainment",
                         Price = 24.99M
                     },

                     new Game
                     {
                         Name = "The Land Adventure of the Last Merman",
                         CoverImageName = "",
                         MediaName = "",
                         ReleaseDate = DateTime.Parse("2016-1-19"),
                         Genre = "Adventure",
                         FileType = "Hard Copy",
                         Device = "PS4",
                         Description = "Explore the ruins of humanity in this mesmerising land action-adventure. Discover thriving wildlife, encounter monstrous beasts, and let curiosity guide you through an inevitable voyage of extinction.",
                         Developer = "JCY",
                         Publisher = "Digger",
                         Price = 24.99M
                     },

                      new Game
                      {
                          Name = "Punking the Cyber 7702",
                          CoverImageName = "",
                          MediaName = "",
                          ReleaseDate = DateTime.Parse("2020-12-10"),
                          Genre = "Sci-Fi",
                          FileType = "Hard Copy",
                          Device = "Xbox One",
                          Description = "An open-world, action-adventure story set in Day City, a megalopolis obsessed with power, glamour and body modification. You play as Z, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.",
                          Developer = "DC",
                          Publisher = "DC",
                          Price = 70.20M
                      },

                      new Game
                      {
                          Name = "Punking the Cyber 7702",
                          CoverImageName = "",
                          MediaName = "",
                          ReleaseDate = DateTime.Parse("2020-12-10"),
                          Genre = "Sci-Fi",
                          FileType = "Hard Copy",
                          Device = "PC",
                          Description = "An open-world, action-adventure story set in Day City, a megalopolis obsessed with power, glamour and body modification. You play as Z, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.",
                          Developer = "DC",
                          Publisher = "DC",
                          Price = 58.99M
                      },

                        new Game
                        {
                            Name = "The Smis",
                            CoverImageName = "",
                            MediaName = "",
                            ReleaseDate = DateTime.Parse("2000-02-4"),
                            Genre = "Simulation",
                            FileType = "Hard Copy",
                            Device = "Xbox One",
                            Description = "Unleash your imagination and create a unique world of Smis to expression yourself! Explore and customize every detail from Smis to homes!",
                            Developer = "Artistic Electro",
                            Publisher = "Artistic Electro",
                            Price = 60.10M
                        },

                         new Game
                         {
                             Name = "Luigi Kart 10.0 Deluxe",
                             CoverImageName = "",
                             MediaName = "",
                             ReleaseDate = DateTime.Parse("2020-12-10"),
                             Genre = "Racing",
                             FileType = "Hard Copy",
                             Device = "Nintendo Switch",
                             Description = "Race up to 4 of your friends or battle them in a revised battle mode on new and returning battle courses.",
                             Developer = "Nine Ten Dos",
                             Publisher = "Nine Ten Dos",
                             Price = 30M
                         }


                );


                context.SaveChanges();
            }
        }
        /*   public List<Game> findAll()
           {
               return Game;
           }

           public Game find(string id)
           { 
               return Game.Where(p => p.Id == id).FirstOrDefault();
           }*/
       }
    }

