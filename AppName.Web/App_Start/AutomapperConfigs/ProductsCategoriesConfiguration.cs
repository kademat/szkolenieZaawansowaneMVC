using AppName.Domains;
using AppName.Web.ViewModels.ProductCategories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.App_Start.AutomapperConfigs
{
    public class ProductsCategoriesConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<ProductCategory, IndexItemViewModel>();
        }
    }
}