# HotChocolate_GraphQL_Demo_Application
This is the demo application to learn the basics of HotChocolate and GraphQL.

### Using the command line

Restore the NuGet packages and run the application:
```bash
dotnet restore

dotnet run
```

## Calling the API
Download Banana Cake POP Tool.
Go to `https://localhost:5000` in Banana Cake POP to access the schema of graphQL.
 
## TestData: To get weather information for all cities | Type: Query

```
{
  weatherInfos{
    city,
    minTemp,
    maxTemp,
    averageTemp,
    dewPoint,
    humidity,
    day,
    month,
    year
  }
}
```

## TestData: To get weather information for Specific city | Type: Query
```
{
  weatherInfoByCity(cityName: "Agra"){
    city,
    minTemp,
    maxTemp,
    averageTemp,
    dewPoint,
    humidity,
    day,
    month,
    year
  }
```

## TestData: Add new weather information | Type: Mutation

```
mutation{
  createWeatherInfo(dateTime:"2020-05-17T00:00:00Z", minTemp:23, maxTemp:40, city:"Indore"){
    iD,
    city,
    maxTemp,
    minTemp,
    averageTemp,
    date,
    day,
    month  
  }
}
```
