using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I0QBUW_zh2.Classes
{
    public class DetailedRating : Rating
    {
        public string RatingSeason { get; set; }
        protected override string GetDisplayText(string s)
        {
            s = Title + RatingSeason;
            return s;
        }
    }
}
