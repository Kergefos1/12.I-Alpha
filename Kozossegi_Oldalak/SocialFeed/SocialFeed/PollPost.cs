using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;

        public int Votes { get { return _votes; } }
        public bool IsClosed { get { return _isClosed; } }

        public PollPost(string author) : base(author)
        {
            _votes = 0;
        }

        public bool Vote()
        {
            if (!IsClosed)
            {
                _votes++;
                return true;
            }
            else
                return false;
        }

        public void Close()
        {
            _isClosed = true;
        }

        public override int Score()
        {
            return Likes + Votes;
        }

        public override string GetDescribtion()
        {
            return base.GetDescribtion() + $", {Votes} szavazatot";
        }

        public override bool Like()
        {
            if (!IsClosed)
                return base.Like();
            else
                return false;
        }

    }
}
