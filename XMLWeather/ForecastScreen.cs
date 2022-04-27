using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            string minTemp;
            string maxTemp;

            date1.Text = Form1.days[1].date;
            min1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow)).ToString();
            max1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)).ToString();
            weatherOutput1.Text = Form1.days[1].condition;

            minTemp = min1.Text;
            min1.Text = $"{minTemp}°C";

            maxTemp = max1.Text;
            max1.Text = $"{maxTemp}°C";

            date2.Text = Form1.days[2].date;
            min2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow)).ToString();
            max2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)).ToString();
            weatherOutput2.Text = Form1.days[2].condition;

            minTemp = min2.Text;
            min2.Text = $"{minTemp}°C";

            maxTemp = max2.Text;
            max2.Text = $"{maxTemp}°C";

            date3.Text = Form1.days[3].date;
            min3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow)).ToString();
            max3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)).ToString();
            weatherOutput3.Text = Form1.days[3].condition;

            minTemp = min3.Text;
            min3.Text = $"{minTemp}°C";

            maxTemp = max3.Text;
            max3.Text = $"{maxTemp}°C";

            date4.Text = Form1.days[4].date;
            min4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow)).ToString();
            max4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)).ToString();
            weatherOutput4.Text = Form1.days[4].condition;

            minTemp = min4.Text;
            min4.Text = $"{minTemp}°C";

            maxTemp = max4.Text;
            max4.Text = $"{maxTemp}°C";

            date5.Text = Form1.days[5].date;
            min5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow)).ToString();
            max5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh)).ToString();
            weatherOutput5.Text = Form1.days[5].condition;

            minTemp = min5.Text;
            min5.Text = $"{minTemp}°C";

            maxTemp = max5.Text;
            max5.Text = $"{maxTemp}°C";

            date6.Text = Form1.days[6].date;
            min6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow)).ToString();
            max6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh)).ToString();
            weatherOutput6.Text = Form1.days[6].condition;

            minTemp = min6.Text;
            min6.Text = $"{minTemp}°C";

            maxTemp = max6.Text;
            max6.Text = $"{maxTemp}°C";

         
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            SearchScreen cs = new SearchScreen();
            f.Controls.Add(cs);
        }
    }
}
