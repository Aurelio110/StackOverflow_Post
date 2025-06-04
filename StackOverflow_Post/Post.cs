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
            

       


        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Describtion
        {
            get { return describtion; }
            set { describtion = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public int Votes
        {
            get { return votes; }
            set { votes = value; }
        }

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
