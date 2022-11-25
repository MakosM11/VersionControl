using I0QBUW_zh2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace I0QBUW_zh2
{
    public partial class Form1 : Form
    {
        List<Rating> _ratings = new List<Rating>();

        public Form1()
        {
            InitializeComponent();

            var serviceRef = new ServiceSoapClient();
            var request = serviceRef.GetExportWithTitle("Halloween");

            var xml = new XmlDocument();
            xml.LoadXml(request);
            foreach (XmlElement element in xml.DocumentElement)
            {
                //var
                //_ratings.Add(rate);
                
            }

            Appear();
            
        }

        private void Appear()
        {
            foreach (var s in _ratings)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
