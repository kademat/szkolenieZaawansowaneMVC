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
        public User()
        {
            Address = new Address();
        }


        [Display(ResourceType = typeof(UserResources), Name = "Name")]
        public string Name { get; set; }

        public string Email { get; set; }

        public bool CreateInvoide { get; set; }

        public string Nip { get; set; }

        public Address Address { get; set; }

        public List<Order> Orders { get; set; }

    }
}
