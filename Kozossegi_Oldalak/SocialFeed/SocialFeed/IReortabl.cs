using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public interface IReportable
    {
        public void Report();
        public int ReportCount();
        public string GetDescribtion();
    }
}
