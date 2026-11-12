using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class TextPost : Post
    {
        private string _text;

        public string Text { get { return _text; } set { _text = value; } }


        public TextPost(string author, string text) : base(author) { }


        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescribtion()
        {
            if(Text.Length > 20)
            {
                return base.GetDescribtion() + $": {Text}...";
            }
            else
            {
                return base.GetDescribtion() + $": {Text}";
            }
        }

    }
}
