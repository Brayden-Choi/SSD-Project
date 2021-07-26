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
                    return; // DB has been seeded
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
                        Description =
                            "Kingdom Spade III shares the power of friendship as Dora and his friends embark on an adventure. Travelling around the world, Kingdom Spades III follows the journey of Dora, a monkey and a map to a spectecular power.",
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
                        Description =
                            "Undercooked is a calm cooking game for 1 to 4 players. Working individually, you must sabotage your fellow chefs. Sharpen your knives and dust off your chef’s whites, there is mushroom for error and the steaks are high in these crazy kitchens!",
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
                        Description =
                            "Embark on a journey across Tavyet to find your lost sibling and seek answers from The Seven — the 7-11 managers. Explore this wondrous world, join forces with a diverse range of characters, and unravel the countless mysteries that Tavyet holds...",
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
                        Description =
                            "Socket League is a high-powered hybrid of arcade-style soccer and technological mayhem with easy-to-understand controls and fluid, electrical-driven competition.",
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
                        Description =
                            "The Manley Parable is a first person exploration game. You will play as Stanley, and you will not play as Manley. You will follow a story, you will not follow a story. You will have a choice, you will have no choice. The game will end, the game will never end.",
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
                        Description =
                            "Claus is lost and alone. Who? Where? Why? He doesn't know anything. Only you can help him find the truth. Join Claus and K1 - a friendly brute - as you explore this puzzle platform game based on precision, through a geometric kaleidoscope world with high contrast and pop art.  ",
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
                        Description =
                            "Explore the ruins of humanity in this mesmerising land action-adventure. Discover thriving wildlife, encounter monstrous beasts, and let curiosity guide you through an inevitable voyage of extinction.",
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
                        Description =
                            "An open-world, action-adventure story set in Day City, a megalopolis obsessed with power, glamour and body modification. You play as Z, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.",
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
                        Description =
                            "An open-world, action-adventure story set in Day City, a megalopolis obsessed with power, glamour and body modification. You play as Z, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.",
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
                        Description =
                            "Unleash your imagination and create a unique world of Smis to expression yourself! Explore and customize every detail from Smis to homes!",
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
                        Description =
                            "Race up to 4 of your friends or battle them in a revised battle mode on new and returning battle courses.",
                        Developer = "Nine Ten Dos",
                        Publisher = "Nine Ten Dos",
                        Price = 30M
                    },

                    new Game
                    {
                        Name = "Cunter-Strike: Local Defensive",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2012-08-22"),
                        Genre = "FPS",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description =
                            "Cunter-Strike: Local Defensive (CSLD) expands upon the team-based action gameplay that it pioneered when it was launched 19 years ago. CS: LD features new maps, characters, weapons, and game modes, and delivers updated versions of the classic CS content (de_dirt2, etc.).",
                        Developer = "Vulve, Unhidden Trail Entertainment",
                        Publisher = "Vulve",
                        Price = 12.99M
                    },


                    new Game
                    {
                        Name = "Run n Gun",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2020-06-2"),
                        Genre = "FPS",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description =
                            "A super realistic game where players can just run and gun and headshot other players",
                        Developer = "Protest Games",
                        Publisher = "Protest Games",
                        Price = 0.01M
                    },

                    new Game
                    {
                        Name = "F1 2021",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2021-07-15"),
                        Genre = "Racing",
                        FileType = "Soft Copy",
                        Device = "PS4",
                        Description =
                            "Every story has a beginning in F1® 2021, the official videogame of the 2021 FIA FORMULA ONE WORLD CHAMPIONSHIP™. Enjoy the stunning new features of F1® 2021, including the thrilling story experience ‘Braking Point’, two-player Career, and get even closer to the grid with ‘Real-Season Start’.",
                        Developer = "CodeMasters",
                        Publisher = "Ancient Arts",
                        Price = 79.9M
                    },

                    new Game
                    {
                        Name = "FIFA 22",
                        CoverImageName = "",
                        MediaName = "",
                        ReleaseDate = DateTime.Parse("2021-7-17"),
                        Genre = "Football",
                        FileType = "Soft Copy",
                        Device = "PC",
                        Description =
                            "FIFA is the world's most rage-inducing pay-to-win football game. Every year, millions of players break their controller, keyboard and monitors over the thrilling and toxic gameplay! Developer's Note: The only thing we add each year is 1 to the year.",
                        Developer = "Ancient Arts",
                        Publisher = "Ancient Arts",
                        Price = 99.99M
                    }
                );


                context.SaveChanges();
            }
        }
    }
}

