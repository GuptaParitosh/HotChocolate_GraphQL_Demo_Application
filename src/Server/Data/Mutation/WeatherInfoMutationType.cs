using HotChocolate.Types;
using Server.Mutation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data.Mutation
{
    public class WeatherInfoMutationType: ObjectType<WeatherInfoMutation>
    {
        protected override void Configure(IObjectTypeDescriptor<WeatherInfoMutation> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Field(f => f.CreateWeatherInfo(default, default,default,default,default))
                       .Argument("city", a => a.Type<StringType>())
                       .Argument("minTemp",a=>a.Type<FloatType>())
                       .Argument("maxTemp", a => a.Type<FloatType>())
                       .Argument("dateTime", a => a.Type<DateTimeType>());
        }
    }
}
