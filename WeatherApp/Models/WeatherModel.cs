using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.Models
{
    public class WeatherModel
    {
        [JsonProperty("name")]
        public string City { get; set; }

        [JsonProperty("main")]
        public MainWeatherInfo Main { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonProperty("wind")]
        public WindInfo Wind { get; set; }

        public string IconUrl => Weather != null && Weather.Count > 0 ? $"https://openweathermap.org/img/wn/{Weather[0].Icon}@2x.png" : string.Empty;
    }

    public class MainWeatherInfo
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; }

        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class WindInfo
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public int Degree { get; set; }
    }
}

