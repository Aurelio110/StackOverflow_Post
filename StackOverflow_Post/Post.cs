using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Post
    {
        private string title;
        private string describtion;
        private DateTime dateCreated;
        private int votes = 0;

        public Post(string title, string description)
        {
            this.title = title;
            this.describtion = description;
            this.dateCreated = DateTime.Now;
        }
        public Post(string title, string description, int votes)
            : this(title, description)
        {
            this.votes = votes;
        }
            

       


        public string Title { get; set; }
        
        public string Describtion { get; set; }
        
        public DateTime DateCreated { get; set; }

        public int Votes { get; set; }


        public int upvote()
        {
            votes++;
            return votes;
        }
        public int downvote()
        {
            if (votes > 0)
            {
                votes--;
            }
            return votes;
        }


    }
}
