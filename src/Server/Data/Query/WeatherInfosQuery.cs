using HotChocolate;
using Microsoft.EntityFrameworkCore;
using Server.Mutation.Context;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;

namespace Server.Mutation.Query
{
    public class WeatherInfosQuery
    {
        public async Task<List<WeatherInfoModel>> GetWeatherInfos([Service] SqlLiteDataContext dataContext) =>
            await dataContext.WeatherInfos.AsNoTracking().OrderBy(o => o.City).ToListAsync();

        public async Task<List<WeatherInfoModel>> GetWeatherInfoByCity([Service] SqlLiteDataContext dataContext, string cityName) =>
            await dataContext.WeatherInfos.AsNoTracking().Where(x=>x.City==cityName).ToListAsync();
    }
}
