using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace Server.Mutation.Query
{
    public class WeatherinfosQueryType:ObjectType<WeatherInfosQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<WeatherInfosQuery> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(f => f.GetWeatherInfos(default));
            descriptor.Field(f => f.GetWeatherInfoByCity(default, default))
                       .Argument("cityName", a => a.Type<StringType>());
        }
    }
}
