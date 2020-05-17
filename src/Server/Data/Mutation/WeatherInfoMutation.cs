using Server.Mutation.Context;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using HotChocolate;

namespace Server.Mutation
{
    public class WeatherInfoMutation
    {
        public async Task<WeatherInfoModel> CreateWeatherInfo([Service] SqlLiteDataContext dataContext, string city, float minTemp, float maxTemp, DateTime dateTime)
        {
            Console.WriteLine(minTemp);
            WeatherInfoModel weatherInfo = new WeatherInfoModel
            {
                date = dateTime,
                City = city,
                MinTemp = minTemp,
                MaxTemp = maxTemp
            };
            await dataContext.WeatherInfos.AddAsync(weatherInfo);
            await dataContext.SaveChangesAsync();
            return weatherInfo;

        }
    }
}
