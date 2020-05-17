using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Model;

namespace Server.Mutation.Context
{
    public class SqlLiteDataContext:DbContext
    {
        public SqlLiteDataContext(DbContextOptions<SqlLiteDataContext> options) : base(options)
        {

        }
        public DbSet<WeatherInfoModel> WeatherInfos { get; set; }
    }
}
