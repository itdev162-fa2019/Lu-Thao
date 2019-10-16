using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post{
                        Title = "First post!",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et"
                    },
                    new Post{
                        Title = "This is my second post.",
                        Date = DateTime.Now.AddDays(-7),
                        Body = " quis nostrud exercitation ullamco laboris nisi ut aliquip ex"
                    },
                    new Post{
                        Title = "Another day, another post.",
                        Date = DateTime.Now.AddDays(-4),
                        Body = " quis nostrud exercitation ullamco laboris nisi ut aliquip ex"
                    }

                    };
                    context.Posts.AddRange(Posts);
                    context.SaveChanges();
                }
            }
        }
    }
