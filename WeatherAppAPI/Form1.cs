using Newtonsoft.Json;
using RestSharp;
using System.ComponentModel.Design.Serialization;
using System.Net;
using System.Net.Http;
using static WeatherAppAPI.WeatherInfo;

namespace WeatherAppAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbCondition.SizeMode = PictureBoxSizeMode.Zoom;
        }

        string apiKey = "593049b246201ece18bd6d7224dd5bf1";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdGetWeather_Click(object sender, EventArgs e)
        {

        }

        private async void getWeather()
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={Uri.EscapeDataString(txtCity.Text)}&appid={apiKey}&units=metric";
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var json = await client.GetStringAsync(url);
                    try
                    {
                        Root weatherData = JsonConvert.DeserializeObject<Root>(json);

                        lblTemp.Text = $" {Math.Round(weatherData.Main.Temp)}°C";
                        lblCondition.Text = $" {weatherData.Weather[0].currentWeather}";
                        lblWindspeed.Text = $" {weatherData.Wind.Speed.ToString()} kph";
                        lblHumidity.Text = $"{weatherData.Main.Humidity} %";

                        pbCondition.ImageLocation = $"https://openweathermap.org/img/w/{weatherData.Weather[0].Icon}.png";
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbCondition_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdGetWeather_Click_1(object sender, EventArgs e)
        {
            getWeather();
            lblLocation.Text = txtCity.Text.ToUpper();
            txtCity.Text = "";
        }

        private void lblWindspeed_Click(object sender, EventArgs e)
        {

        }
    }
}
