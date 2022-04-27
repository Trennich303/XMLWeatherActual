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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            string currentTemp;
            string minTemp;
            string maxTemp; 

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)).ToString();
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow)).ToString();
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)).ToString();
            weatherOutput.Text = Form1.days[0].condition;
            currentDate.Text = Form1.days[0].date;

            currentTemp = tempLabel.Text;
            tempLabel.Text = $"{currentTemp}°C";

            minTemp = minOutput.Text;
            minOutput.Text = $"{minTemp}°C";

            maxTemp = maxOutput.Text;
            maxOutput.Text = $"{maxTemp}°C";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

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
