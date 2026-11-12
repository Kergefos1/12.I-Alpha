using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public abstract class Post
    {
        private string _auther;
        private int _likes;

        public string Auther { get { return _auther; } set { _auther = value; } }
        public int Likes { get { return _likes; } }


        public Post(string auther)
        {
            Auther = auther;
            _likes = 0;
        }


        public virtual bool Like()
        {
            _likes += 1;
            return true;
        }

        public virtual string GetDescribtion()
        {
            return $"{Auther}-nek {Likes} Kedvelése van.";
        }

        public abstract int Score();


    }
}
