using AppName.Web.App_Start.AutomapperConfigs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.App_Start
{
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            ProductsCategoriesConfiguration.Configure();

            Mapper.AssertConfigurationIsValid();
        }
    }
}