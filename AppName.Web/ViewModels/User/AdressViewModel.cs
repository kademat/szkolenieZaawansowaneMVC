using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.ViewModels.User
{
    public class AdressViewModel
    {
        public AdressViewModel()
        {
            
        }
        public string City { get; set; }

        private AdressViewModel Adress { get; set; }
    }
}