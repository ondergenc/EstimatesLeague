using System.Collections.Generic;
using EstimatesLeague.Web.Models;

namespace EstimatesLeague.Web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
