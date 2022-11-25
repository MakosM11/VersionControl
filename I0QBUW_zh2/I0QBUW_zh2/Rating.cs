using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I0QBUW_zh2
{
    public abstract class Rating : Button
    {
        public Rating()
        {
            Width = 200;
            Height = 50;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { Text = Title; }
        }

        private string _ratingtype;
        public string RatingType
        {
            get { return _ratingtype; }
            set { ; }
        }

        protected abstract string GetDisplayText(string s);

        public void Mouse_Click(object sender, EventArgs e)
        {
            //GetDisplayText(e.ToString);
        }

    }
}
