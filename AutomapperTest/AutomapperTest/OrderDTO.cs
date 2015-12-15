using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    class OrderDTO
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Cost { get; set; }

        public string Cost2 { get; set; }

        public string Status { get; set; }
    }

    class MyOrderDTO : OrderDTO
    {
        public string Description { get; set; }
    }
}
