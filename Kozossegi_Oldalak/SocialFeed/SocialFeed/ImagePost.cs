using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class ImagePost : Post
    {
        private int _imageCount;

        public int ImageCount { get { return _imageCount; } set { if (_imageCount! >= 1 && _imageCount! <= 10) { _imageCount = 1; } else _imageCount = value; } }

        public ImagePost(string author, int imagecount) : base(author)
        {
            ImageCount = imagecount;
        }

        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescribtion()
        {
            return base.GetDescribtion()+ $", {_imageCount} Kép";
        }

    }
}
