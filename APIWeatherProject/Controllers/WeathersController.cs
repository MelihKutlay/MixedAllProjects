using APIWeatherProject.Context;
using APIWeatherProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace APIWeatherProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Şehir Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var Value = context.Cities.Find(id);
            context.Cities.Remove(Value);
            context.SaveChanges();
            return Ok("Şehir Silindi");
        }
        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var values = context.Cities.Find(city.CityID);
            values.CityName = city.CityName;
            values.Country = city.Country;
            values.Temp = city.Temp;
            values.Detail = city.Detail;
            context.SaveChanges();
            return Ok("Güncellendi");
        }
        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            return Ok(value);
        }
        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var values = context.Cities.Count();
            return Ok("Toplam Şehir Sayısı : " + values);
        }
        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var values = context.Cities.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok("En Yüksek Sıcaklığa Sahip Şehir : " + values);
        }
        [HttpGet("MinTempCityName")]
        public IActionResult MinTempCityName()
        {
            var values = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok("En Düşük Sıcaklığa Sahip Şehir : " + values);
        }
    }
}
