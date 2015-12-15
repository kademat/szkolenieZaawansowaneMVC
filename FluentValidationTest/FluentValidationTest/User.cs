using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationTest
{
    class User
    {
        [Display(ResourceType = typeof(UserResources), Name = "Nazwa")]
        public string Name { get; set; }

        public string Email { get; set; }

        public bool CreateInvoide { get; set; }

        public string Nip { get; set; }


    }
}
