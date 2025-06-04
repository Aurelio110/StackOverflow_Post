using System;
using System.Reflection;



namespace StackOverflow_Post
{
    class main
    {
        public static void Main(string[] args)
        {
            var post1 = new Post("My First Post", "This is the description of my first post.", 1);
            var post2 = new Post("My Second Post", "This is the description of my second post.", 2);

            Console.WriteLine(post1.DateCreated);
            Console.WriteLine(post1.Votes);

            post1.Votes = 5;
            post1.Title = "Updated Post Title";
            post1.Describtion = "Updated description for my first post.";
            post1.upvote();
            post1.downvote();
            Console.WriteLine(post1.Votes);
        }
    }
}