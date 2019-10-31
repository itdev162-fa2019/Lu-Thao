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
            if(!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum."
                    },
                     new Post {
                        Title = "Second Post",
                        Date = DateTime.Now.AddDays(-7),
                        Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum."
                    },
                     new Post {
                        Title = "First Post",
                        Date = DateTime.Now.AddDays(-4),
                        Body = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum."
                    }
                };
                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}