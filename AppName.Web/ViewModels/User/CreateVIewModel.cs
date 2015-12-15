using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppName.Web.ViewModels.User
{
    public class CreateViewModel
    {
        public CreateViewModel()
        {
            Address = new AdressViewModel();
        }
        public string Name { get; set; }

        public AdressViewModel Address { get; set; }

    }
}