using System;
using System.Reflection;



namespace StackOverflow_Post
{
    public class main
    {
        public static void Main(string[] args)
        {
            var post1 = new Post("My First Post", "This is the description of my first post.", 1);
            var post2 = new Post("My Second Post", "This is the description of my second post.", 2);

            Console.WriteLine(post1.DateCreated);
            Console.WriteLine(post1.Votes);

            post1.Votes = 5;
            post1.Title = "Updated Post Title";
            post1.Description = "Updated description for my first post.";
            post1.Upvote();
            post1.Downvote();
            post2.Title = "Updated Second Post Title";
            Console.WriteLine(post2.Title);
        }
    }
}