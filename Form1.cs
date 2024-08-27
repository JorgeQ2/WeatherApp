using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "83dc185645f9430199d222126242708";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string weather = await GetWeatherAsync(city);
            lblWeather.Text = weather;
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
