﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.ViewModels.ProductCategories
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Categories = new List<IndexItemViewModel>();
        }

        public IEnumerable<IndexItemViewModel> Categories { get; set; }
    }

    public class IndexItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}