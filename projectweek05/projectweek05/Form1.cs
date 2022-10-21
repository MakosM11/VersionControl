using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectweek05.MnbServiceReference;
using projectweek05.Entities;
using System.Xml;

namespace projectweek05
{
    public partial class Form1 : Form
    {
        BindingList<Entities.RateData> Rates = new BindingList<Entities.RateData>();
        
        
        public Form1()
        {
            InitializeComponent();
            GetExchangeRates();
            dataGridView1.DataSource = Rates;
            xml_task();
            

        }

        public void xml_task()
        {
            


        }

        public void GetExchangeRates()
        {

            //WebSzolg

            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            //XML

            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("Date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                rate.currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("Unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
